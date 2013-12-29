using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandeisMobile
{
    public class Photo
    {
        public string id { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string title { get; set; }
        public int isprimary { get; set; }
        public string dateupload { get; set; }
        public string url_s { get; set; }
        public string height_s { get; set; }
        public string width_s { get; set; }
    }

    public class FlickrAlbum
    {
        public Photoset photoset { get; set; }
        public string stat { get; set; }
    }
}
