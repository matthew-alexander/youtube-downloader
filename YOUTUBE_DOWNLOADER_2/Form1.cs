using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YOUTUBE_DOWNLOADER_2
{
    public partial class frmYTDownloader : Form
    {
        public frmYTDownloader()
        {
            InitializeComponent();
            cboFileType.SelectedIndex = 0; // this sets the combo box for file type to video as a default

            //sets path to my documents
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // sets the file browser to the folder path , which is my documents
            folderBrowserDialog1.SelectedPath = folder; 
        }

        private void frmYTDownloader_Load(object sender, EventArgs e)
        {

        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                txtPath.Text = folderBrowserDialog1.SelectedPath; 
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Our test youtube link
            string link = txtLink.Text;

            Tuple<bool, string> isLinkGood = ValidateLink();
            if(isLinkGood.Item1 == true)
            {
                RestrictAccessibilty();
                Download(isLinkGood.Item2);                
            }
            

        }

        private void Download(string validatedLink)
        {
            if(cboFileType.SelectedIndex == 0)
            {
                YouTubeVideoModel videoDownloader = new YouTubeVideoModel();
                videoDownloader.Link = validatedLink;
                videoDownloader.FolderPath = txtPath.Text;
                DownloadVideo(videoDownloader); 
            }
            else
            {
                YouTubeAudioModel audioDownloader = new YouTubeAudioModel();
                audioDownloader.Link = validatedLink;
                audioDownloader.FolderPath = txtPath.Text;
                DownloadAudio(audioDownloader);
            }
        }

        private void DownloadAudio(YouTubeAudioModel audioDownloader)
        {
            try
            {
                audioDownloader.VideoInfo = FileDownloader.GetVideoInfos(audioDownloader);
                audioDownloader.Video = FileDownloader.GetVideoInfoAudioOnly(audioDownloader);
                lblFileName.Text = audioDownloader.Video.Title + audioDownloader.Video.AudioExtension;
                audioDownloader.FilePath = FileDownloader.GetPath(audioDownloader);
                audioDownloader.FilePath += audioDownloader.Video.AudioExtension;

                audioDownloader.AudioDownloaderType = FileDownloader.GetAudioDownloader(audioDownloader);

                //events that do code when things happen
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => EnableAccessibility();
                //open the folder with downloaded file selected
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => OpenFolder(audioDownloader.FilePath);
                audioDownloader.AudioDownloaderType.DownloadProgressChanged += (sender, args) => pgDownload.Value = (int)args.ProgressPercentage;
                CheckForIllegalCrossThreadCalls = false;

                FileDownloader.DownloadAudio(audioDownloader); 
                 
            }
            catch
            {
                MessageBox.Show("Download Cancelled.");
                EnableAccessibility(); 
            }
        }

        private void DownloadVideo(YouTubeVideoModel videoDownloader)
        {
            try
            {
                videoDownloader.VideoInfo = FileDownloader.GetVideoInfos(videoDownloader);
                videoDownloader.Video = FileDownloader.GetVideoInfo(videoDownloader);

                lblFileName.Text = videoDownloader.Video.Title; 

                videoDownloader.FilePath = FileDownloader.GetPath(videoDownloader);
                videoDownloader.FilePath += videoDownloader.Video.VideoExtension;
                videoDownloader.VideoDownloaderType = FileDownloader.GetVideoDownloader(videoDownloader);

                //events that do code when things happen
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => EnableAccessibility();
                //open the folder with downloaded file selected
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => OpenFolder(videoDownloader.FilePath);
                videoDownloader.VideoDownloaderType.DownloadProgressChanged += (sender, args) => pgDownload.Value = (int)args.ProgressPercentage;
                CheckForIllegalCrossThreadCalls = false; 

                //download video
                FileDownloader.DownloadVideo(videoDownloader); 
            }
            catch
            {
                MessageBox.Show("Download Cancelled.");
                EnableAccessibility(); 
            }
        }

        private void OpenFolder(string filePath)
        {
            string argument = "/select, \"" + filePath + "\""; 
            if(chk_OpenAfterDownload.Checked == true)
            {
                Process.Start("explorer.exe", argument); 
            }
        }

        private void EnableAccessibility()
        {
            txtLink.Text = "";
            lblFileName.Text = ""; 
            btnDownload.Enabled = true;
            cboFileType.Enabled = true;
            btnChoosePath.Enabled = true;
            txtLink.Enabled = true;
            txtPath.Enabled = true;
            pgDownload.Value = 0; 
        }

        private void RestrictAccessibilty()
        {
            btnDownload.Enabled = false;
            cboFileType.Enabled = false;
            btnChoosePath.Enabled = false;
            txtLink.Enabled = false;
            txtPath.Enabled = false; 
        }

        private Tuple<bool, string> ValidateLink()
        {
            string normalURL;
            if (!Directory.Exists(txtPath.Text))
            {
                MessageBox.Show("Please enter a valid download path.");
                return Tuple.Create(false, ""); 
            }
            else if(DownloadUrlResolver.TryNormalizeYoutubeUrl(txtLink.Text, out normalURL))
            {
                return Tuple.Create(true, normalURL);
            }else
            {
                MessageBox.Show("Please enter a valid YouTube link.");
                return Tuple.Create(false, ""); 
            }
        }
    }
}
