using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandeisMobile
{
    public class Photoset
    {
        public string id { get; set; }
        public string primary { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public int photos { get; set; }
        public int videos { get; set; }
        public Title title { get; set; }
        public Description description { get; set; }
        public int needs_interstitial { get; set; }
        public int visibility_can_see_set { get; set; }
        public object count_views { get; set; }
        public int count_comments { get; set; }
        public int can_comment { get; set; }
        public string date_create { get; set; }
        public string date_update { get; set; }
        public List<Photo> photo { get; set; }
        public string owner { get; set; }
        public string ownername { get; set; }
        public int page { get; set; }
        public string per_page { get; set; }
        public string perpage { get; set; }
        public int pages { get; set; }
        public int total { get; set; }
    }
    
    public class Title
    {
        public string _content { get; set; }
    }

    public class Description
    {
        public string _content { get; set; }
    }

    public class PrimaryPhotoExtras
    {
        public string url_sq { get; set; }
        public int height_sq { get; set; }
        public int width_sq { get; set; }
    }

    public class Photosets
    {
        public int page { get; set; }
        public int pages { get; set; }
        public int perpage { get; set; }
        public int total { get; set; }
        public List<Photoset> photoset { get; set; }
    }

    public class FlickrData
    {
        public Photosets photosets { get; set; }
        public string stat { get; set; }
    }
}
