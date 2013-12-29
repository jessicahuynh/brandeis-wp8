using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Net.Http;
using Newtonsoft.Json;

namespace BrandeisMobile
{
    public partial class Photos : PhoneApplicationPage
    {
        public Photos()
        {
            InitializeComponent();
            Loaded += Photos_Loaded;
        }

        public void Photos_Loaded(object sender, EventArgs e)
        {
            PopulateSets();
        }

        private async void PopulateSets()
        {
            var set = await FlickrImage.GetFlickrImageSet(FlickrImage.FlickrAPI);

            DataContext = set;
        }

        private void Sets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sets.SelectedItem == null)
                return;

            this.NavigationService.Navigate(new Uri("/Album.xaml?goto=" + (List<Photo>)Photosets.Photoset.IndexOf(Sets.SelectedItem), UriKind.Relative));

            Sets.SelectedItem = null;
        }
    }
}