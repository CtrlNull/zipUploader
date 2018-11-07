using System.Collections.Generic;
using System.Net.Http;

namespace zipUploader.Models
{
    public class ZipUploaderContainer
    {
        public string FileName { get; set; }
        public string FileComment { get; set; }
        public List<string> NoFileMatch { get; set; }
    }

    public class Exceptions {
        public Exceptions StreamFailure { get; set; }
        public Exceptions LoopBuildFailure { get; set; }
        public HttpResponseMessage Response { get; set; }
    }
}