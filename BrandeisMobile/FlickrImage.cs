using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace BrandeisMobile
{
    class FlickrImage
    {
        public Uri squareUrl { get; set; }
        public Uri gridUrl { get; set; }
        public string setTitle { get; set; }
        public string setDescription { get; set; }

        private const string BrandeisFlickr = "39726096@N05";
        public const string FlickrAPI = "bad1939afdc0371180c9f787fbf4871e";

        public async static Task<List<FlickrImage>> GetFlickrImageSet(string FlickrAPI)
        {
            HttpClient client = new HttpClient();

            string baseUrl = getBaseUrl(FlickrAPI);

            string flickrResult = await client.GetStringAsync(baseUrl);

            FlickrData apiData = JsonConvert.DeserializeObject<FlickrData>(flickrResult);

            List<FlickrImage> images = new List<FlickrImage>();

            if (apiData.stat == "ok")
            {
                foreach (Photoset data in apiData.photosets.photoset)
                {
                    FlickrImage img = new FlickrImage();
                    
                    // photo url: http://farm{farm-id}.staticflickr.com/{server-id}/{id}_{secret}.jpg

                    string photoUrl = "http://farm{0}.staticflickr.com/{1}/{2}_{3}";

                    string baseFlickrUrl = string.Format(photoUrl,
                        data.farm,
                        data.server,
                        data.primary,
                        data.secret);

                    img.squareUrl = new Uri(baseFlickrUrl + "_q.jpg");
                    img.setTitle = data.title._content;
                    img.setDescription = data.photos.ToString();

                    images.Add(img);
                }
            }
            return images;
        }

        public async static Task<List<FlickrImage>> GetFlickrAlbum(string FlickrAPI)
        {
            HttpClient client = new HttpClient();

            string baseUrl = getBaseUrl(FlickrAPI);

            string flickrResult = await client.GetStringAsync(baseUrl);

            FlickrAlbum apiData = JsonConvert.DeserializeObject<FlickrAlbum>(flickrResult);

            List<FlickrImage> images = new List<FlickrImage>();

            if (apiData.stat == "ok")
            {
                foreach (Photo data in apiData.photoset.photo)
                {
                    FlickrImage img = new FlickrImage();

                    // photo url: http://farm{farm-id}.staticflickr.com/{server-id}/{id}_{secret}.jpg

                    string photoUrl = "http://farm{0}.staticflickr.com/{1}/{2}_{3}";

                    string baseFlickrUrl = string.Format(photoUrl,
                        data.farm,
                        data.server,
                        data.id,
                        data.secret);

                    img.gridUrl = new Uri(baseFlickrUrl + "_s.jpg");

                    images.Add(img);
                }
            }

            return images;
        }

        private static string getBaseUrl(string FlickrApi)
        {
            //string FlickrSecret = "2543bc57e539039e";

            string url = "http://api.flickr.com/services/rest/" +
                "?method=flickr.photosets.getList" +
                "&api_key={0}" +
                "&user_id={1}" +
                "&primary_photo_extras=url_sq" +
                "&format=json" +
                "&nojsoncallback=1";

            var baseUrl = string.Format(url, FlickrAPI, BrandeisFlickr);

            return baseUrl;
        }
    }
}
