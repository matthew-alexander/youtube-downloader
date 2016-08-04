namespace YOUTUBE_DOWNLOADER_2
{
    partial class frmYTDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTDownloader));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDecorateFolder = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.chk_OpenAfterDownload = new System.Windows.Forms.CheckBox();
            this.lblDecorateURLBox = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblDecorateCurrentFile = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblDecorateProgressBar = new System.Windows.Forms.Label();
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDecorateFolder
            // 
            this.lblDecorateFolder.AutoSize = true;
            this.lblDecorateFolder.Location = new System.Drawing.Point(24, 90);
            this.lblDecorateFolder.Name = "lblDecorateFolder";
            this.lblDecorateFolder.Size = new System.Drawing.Size(107, 17);
            this.lblDecorateFolder.TabIndex = 1;
            this.lblDecorateFolder.Text = "Download Path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(137, 90);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(334, 22);
            this.txtPath.TabIndex = 2;
            this.txtPath.Text = "C:\\Users\\mda45\\Videos";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(477, 90);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePath.TabIndex = 3;
            this.btnChoosePath.Text = "Choose";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // chk_OpenAfterDownload
            // 
            this.chk_OpenAfterDownload.AutoSize = true;
            this.chk_OpenAfterDownload.Location = new System.Drawing.Point(558, 92);
            this.chk_OpenAfterDownload.Name = "chk_OpenAfterDownload";
            this.chk_OpenAfterDownload.Size = new System.Drawing.Size(165, 21);
            this.chk_OpenAfterDownload.TabIndex = 4;
            this.chk_OpenAfterDownload.Text = "Open After Download";
            this.chk_OpenAfterDownload.UseVisualStyleBackColor = true;
            // 
            // lblDecorateURLBox
            // 
            this.lblDecorateURLBox.AutoSize = true;
            this.lblDecorateURLBox.Location = new System.Drawing.Point(25, 122);
            this.lblDecorateURLBox.Name = "lblDecorateURLBox";
            this.lblDecorateURLBox.Size = new System.Drawing.Size(106, 17);
            this.lblDecorateURLBox.TabIndex = 5;
            this.lblDecorateURLBox.Text = "YouTube URL: ";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(137, 119);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(334, 22);
            this.txtLink.TabIndex = 6;
            // 
            // cboFileType
            // 
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Items.AddRange(new object[] {
            "Video",
            "MP3"});
            this.cboFileType.Location = new System.Drawing.Point(477, 119);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(75, 24);
            this.cboFileType.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(558, 119);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(85, 24);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblDecorateCurrentFile
            // 
            this.lblDecorateCurrentFile.AutoSize = true;
            this.lblDecorateCurrentFile.Location = new System.Drawing.Point(25, 153);
            this.lblDecorateCurrentFile.Name = "lblDecorateCurrentFile";
            this.lblDecorateCurrentFile.Size = new System.Drawing.Size(119, 17);
            this.lblDecorateCurrentFile.TabIndex = 9;
            this.lblDecorateCurrentFile.Text = "File Downloading:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(151, 153);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(35, 17);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "Title";
            // 
            // lblDecorateProgressBar
            // 
            this.lblDecorateProgressBar.AutoSize = true;
            this.lblDecorateProgressBar.Location = new System.Drawing.Point(25, 170);
            this.lblDecorateProgressBar.Name = "lblDecorateProgressBar";
            this.lblDecorateProgressBar.Size = new System.Drawing.Size(135, 17);
            this.lblDecorateProgressBar.TabIndex = 11;
            this.lblDecorateProgressBar.Text = "Download Progress:";
            // 
            // pgDownload
            // 
            this.pgDownload.Location = new System.Drawing.Point(27, 199);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(696, 23);
            this.pgDownload.TabIndex = 12;
            // 
            // frmYTDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 238);
            this.Controls.Add(this.pgDownload);
            this.Controls.Add(this.lblDecorateProgressBar);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblDecorateCurrentFile);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.cboFileType);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblDecorateURLBox);
            this.Controls.Add(this.chk_OpenAfterDownload);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblDecorateFolder);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYTDownloader";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.frmYTDownloader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDecorateFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.CheckBox chk_OpenAfterDownload;
        private System.Windows.Forms.Label lblDecorateURLBox;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblDecorateCurrentFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblDecorateProgressBar;
        private System.Windows.Forms.ProgressBar pgDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

