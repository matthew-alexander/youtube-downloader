using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace YOUTUBE_DOWNLOADER_2
{
    public class YouTubeModel
    {
        public IEnumerable<VideoInfo> VideoInfo { get; set;}
        public string FolderPath { get; set; } // store the folder we designated
        public string Link { get; set; } // this is the Youtube link we typed in    
        public string FilePath { get; set; } // store the folder location lus the name of the file and the extention
        public VideoInfo Video { get; set; } // object from Youtube Extractor  which contains the info from youtube
    }
    public class YouTubeVideoModel : YouTubeModel
    {
        // this object conntains the execute method
        // DownloadFinished event we can handle when a download is finished
        // this will be used to enable access to the interface after its disabled while a file downloads
        // DownloadProgressChange event which updates the progress bar
        public VideoDownloader VideoDownloaderType { get; set;  }
        
    }
    public class YouTubeAudioModel : YouTubeModel
    {
        // object contains execute download audio method
        //DownloadFinished event 
        //DownloadPRogressChange to update progress bar
        public AudioDownloader AudioDownloaderType { get; set; }

    }
}
