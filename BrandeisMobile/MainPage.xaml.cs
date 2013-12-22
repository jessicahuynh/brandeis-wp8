using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace BrandeisMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Color DeisBlueColor = Color.FromArgb(255, 0, 112, 255);

            ApplicationBar = ThemeManager.CreateApplicationBar();
            ApplicationBar.Mode = ApplicationBarMode.Minimized;
            ApplicationBar.Opacity = .8;
            ApplicationBar.IsVisible = true;
            ApplicationBar.IsMenuEnabled = true;
            ApplicationBar.BackgroundColor = DeisBlueColor;
            ApplicationBar.ForegroundColor = Color.FromArgb(255, 255, 255, 255); //white
     
            ApplicationBarIconButton linksIcon = new ApplicationBarIconButton();
            linksIcon.IconUri = new Uri("/Images/favs.png", UriKind.Relative);
            linksIcon.Text = "links";
            ApplicationBar.Buttons.Add(linksIcon);
            linksIcon.Click += new EventHandler(linksIcon_Click);
            
            ApplicationBarMenuItem full_websiteMenuItem = new ApplicationBarMenuItem();
            full_websiteMenuItem.Text = "full website";
            ApplicationBar.MenuItems.Add(full_websiteMenuItem);
            full_websiteMenuItem.Click += new EventHandler(full_websiteMenuItem_Click);

            ApplicationBarMenuItem aboutMenuItem = new ApplicationBarMenuItem();
            aboutMenuItem.Text = "about";
            ApplicationBar.MenuItems.Add(aboutMenuItem);
            aboutMenuItem.Click += new EventHandler(aboutMenuItem_Click);

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void linksIcon_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Links.xaml", UriKind.Relative));
        }

        private void full_websiteMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void DirectorySearch_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DirectorySearch.Text = "";
        }

        private void landingNavigation_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //NavigationService.Navigate(new Uri((Entry)sender.EntryURL,UriKind.Relative);
        }

        private void CampusServicesButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/DirectoryLinks.xaml?goto=0", UriKind.RelativeOrAbsolute));
        }

        private void AdmissionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/DirectoryLinks.xaml?goto=1", UriKind.RelativeOrAbsolute)); //Admissions is the 2nd pivot
        }

    }
}