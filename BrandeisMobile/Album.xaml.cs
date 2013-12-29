using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace BrandeisMobile
{
    public partial class Album : PhoneApplicationPage
    {
        public Album()
        {
            InitializeComponent();
        }

        public void Album_Loaded(object sender, EventArgs e)
        {
            PopulateAlbum();
        }

        private async void PopulateAlbum()
        {
            var images = await FlickrImage.GetFlickrAlbum(FlickrImage.FlickrAPI);

            DataContext = images;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string strItemIndex = "";

            if (NavigationContext.QueryString.TryGetValue("goto", out strItemIndex))
                album.SelectedIndex = Convert.ToInt32(strItemIndex);

            base.OnNavigatedTo(e);
        }
    }
}