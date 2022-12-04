using Paloma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TargaImageBatchConverter
{
    public partial class Main : Form
    {
        BackgroundWorker BGW = new BackgroundWorker();

        public Main()
        {
            InitializeComponent();
            SPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Converted";

            SelectFiles.Click += SelectFiles_Click;
            Convert.Click += Convert_Click;
            ClearList.Click += ClearList_Click;
            SelectPath.Click += SelectPath_Click;

            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.DoWork += BGW_DoWork;
            BGW.RunWorkerCompleted += BGW_RunWorkerCompleted;
            BGW.ProgressChanged += BGW_ProgressChanged;
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            bool ReplaceFlag = false, NameDiffFlag = false;
            int FileCount = PendingFile.Items.Count, Counter = 0;

            if (!Directory.Exists(SPath.Text))
                Directory.CreateDirectory(SPath.Text);

            foreach (object item in PendingFile.Items)
            {
                if (BGW.CancellationPending)
                {
                    BGW.ReportProgress(0, "Abort");
                    break;
                }

                string FCompletePath = item.ToString();
                string FDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(FCompletePath))).Split(new char[]{'\\', '/'}).Last();
                string FName = Path.GetFileNameWithoutExtension(FCompletePath);
                string SCompletePath = SPath.Text + "/" + FDirectory + " - " + FName + ".png";

                if (!NameDiffFlag && !ReplaceFlag && File.Exists(SCompletePath))
                {
                    DialogResult Res = MessageBox.Show("File name conflicted. Settings you choose later will apply on all files.\nClick \"Retry\" to Name as different.\nClick \"Ignore\" to replace.\nClick \"Abort\" to cancel whole work.", "File Confliction", MessageBoxButtons.AbortRetryIgnore);
                    switch (Res)
                    {
                        case DialogResult.Abort:
                            BGW.CancelAsync();
                            continue;
                        case DialogResult.Ignore:
                            ReplaceFlag = true;
                            break;
                        case DialogResult.Retry:
                            NameDiffFlag = true;
                            break;
                    }
                }

                if (NameDiffFlag)
                {
                    SCompletePath = SPath.Text + "/" + FDirectory + " - " + FName + Guid.NewGuid().ToString().Substring(0, 4) + ".png";
                }

                TargaImage TGA = new TargaImage(FCompletePath);
                TGA.Image.Save(SCompletePath, ImageFormat.Png);
                Counter++;
                BGW.ReportProgress(Counter / FileCount * 100, Counter + "/" + FileCount);
            }
        }

        private void BGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.ToString() == "Abort")
            {
                Convert.Enabled = true;
                MessageBox.Show("TGA to PNG converting aborted.");
            } else
            {
                ProgressText.Text = e.UserState.ToString();
                Progress.PerformStep();
            }
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Convert.Enabled = true;
            MessageBox.Show("TGA to PNG converting completed.");
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Convert.Enabled = false;
            Progress.Value = 0;
            Progress.Maximum = PendingFile.Items.Count;
            BGW.RunWorkerAsync();
        }

        private void SelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Targa File|*.tga";
            OPF.Multiselect = true;
            OPF.Title = "Select files to convert images from TGA to PNG.";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                foreach (string FName in OPF.FileNames)
                {
                    PendingFile.Items.Add(FName);
                }
            }
        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FLD = new FolderBrowserDialog();
            FLD.Description = "Choose the folder you want to save PNGs.";
            FLD.RootFolder = Environment.SpecialFolder.Desktop;
            FLD.ShowNewFolderButton = true;
            if (FLD.ShowDialog() == DialogResult.OK)
            {
                SPath.Text = FLD.SelectedPath;
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            PendingFile.Items.Clear();
        }
    }
}
