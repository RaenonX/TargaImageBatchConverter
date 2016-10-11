namespace TargaImageBatchConverter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PendingFile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFiles = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.ClearList = new System.Windows.Forms.Button();
            this.SelectPath = new System.Windows.Forms.Button();
            this.SPath = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PendingFile
            // 
            this.PendingFile.FormattingEnabled = true;
            this.PendingFile.ItemHeight = 16;
            this.PendingFile.Location = new System.Drawing.Point(12, 77);
            this.PendingFile.Name = "PendingFile";
            this.PendingFile.Size = new System.Drawing.Size(664, 244);
            this.PendingFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pending File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectFiles
            // 
            this.SelectFiles.Location = new System.Drawing.Point(12, 12);
            this.SelectFiles.Name = "SelectFiles";
            this.SelectFiles.Size = new System.Drawing.Size(99, 37);
            this.SelectFiles.TabIndex = 2;
            this.SelectFiles.Text = "Add Files";
            this.SelectFiles.UseVisualStyleBackColor = true;
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.Convert.Location = new System.Drawing.Point(577, 327);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(99, 36);
            this.Convert.TabIndex = 5;
            this.Convert.Text = "CONVERT";
            this.Convert.UseVisualStyleBackColor = true;
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(12, 327);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(559, 14);
            this.Progress.TabIndex = 6;
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(629, 49);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(47, 22);
            this.ClearList.TabIndex = 7;
            this.ClearList.Text = "Clear";
            this.ClearList.UseVisualStyleBackColor = true;
            // 
            // SelectPath
            // 
            this.SelectPath.Location = new System.Drawing.Point(117, 12);
            this.SelectPath.Name = "SelectPath";
            this.SelectPath.Size = new System.Drawing.Size(99, 37);
            this.SelectPath.TabIndex = 8;
            this.SelectPath.Text = "Select Path";
            this.SelectPath.UseVisualStyleBackColor = true;
            // 
            // SPath
            // 
            this.SPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPath.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.SPath.Location = new System.Drawing.Point(222, 12);
            this.SPath.Margin = new System.Windows.Forms.Padding(3);
            this.SPath.Name = "SPath";
            this.SPath.Size = new System.Drawing.Size(454, 37);
            this.SPath.TabIndex = 9;
            this.SPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProgressText
            // 
            this.ProgressText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.ProgressText.Location = new System.Drawing.Point(336, 347);
            this.ProgressText.Margin = new System.Windows.Forms.Padding(3);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(235, 16);
            this.ProgressText.TabIndex = 10;
            this.ProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 377);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.SPath);
            this.Controls.Add(this.SelectPath);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.SelectFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PendingFile);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PendingFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectFiles;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button SelectPath;
        private System.Windows.Forms.Label SPath;
        private System.Windows.Forms.Label ProgressText;
    }
}

