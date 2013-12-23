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
using Microsoft.Phone.Tasks;

namespace BrandeisMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            ApplicationBar = ThemeManager.CreateApplicationBar();
            ApplicationBar.Mode = ApplicationBarMode.Minimized;
            ApplicationBar.Opacity = .8;
            ApplicationBar.IsVisible = true;
            ApplicationBar.IsMenuEnabled = true;

            ApplicationBarIconButton searchIcon = new ApplicationBarIconButton();
            searchIcon.IconUri = new Uri("/Images/feature.search.png", UriKind.Relative);
            searchIcon.Text = "search";
            ApplicationBar.Buttons.Add(searchIcon);
            
            ApplicationBarIconButton linksIcon = new ApplicationBarIconButton();
            linksIcon.IconUri = new Uri("/Images/favs.png", UriKind.Relative);
            linksIcon.Text = "links";
            ApplicationBar.Buttons.Add(linksIcon);
            linksIcon.Click += new EventHandler(linksIcon_Click);

            ApplicationBarIconButton settingsIcon = new ApplicationBarIconButton();
            settingsIcon.IconUri = new Uri("/Images/feature.settings.png", UriKind.Relative);
            settingsIcon.Text = "settings";
            ApplicationBar.Buttons.Add(settingsIcon);
            
            ApplicationBarMenuItem full_websiteMenuItem = new ApplicationBarMenuItem();
            full_websiteMenuItem.Text = "full website";
            ApplicationBar.MenuItems.Add(full_websiteMenuItem);
            full_websiteMenuItem.Click += new EventHandler(full_websiteMenuItem_Click);

            ApplicationBarMenuItem aboutMenuItem = new ApplicationBarMenuItem();
            aboutMenuItem.Text = "about";
            ApplicationBar.MenuItems.Add(aboutMenuItem);
            aboutMenuItem.Click += new EventHandler(aboutMenuItem_Click);

            // Set the data context
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
            App.OpenInBrowser("http://www.brandeis.edu/");
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void DirectorySearch_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DirectorySearch.Text = "";
        }

        // Methods to navigate to specific pivot pages
        // 0 - Campus services
        // 1 - Admissions
        // 2 - Campus locations
        private void CampusServicesButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/DirectoryLinks.xaml?goto=0", UriKind.RelativeOrAbsolute));
        }

        private void AdmissionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/DirectoryLinks.xaml?goto=1", UriKind.RelativeOrAbsolute));
        }

        private void CampusLocationsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/DirectoryLinks.xaml?goto=2", UriKind.RelativeOrAbsolute));
        }

        private void MainLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainLongListSelector.SelectedItem == null)
                return;

            ViewModels.Entry selected = (ViewModels.Entry)MainLongListSelector.SelectedItem;
            this.NavigationService.Navigate(new Uri(selected.EntryURL, UriKind.RelativeOrAbsolute));

           MainLongListSelector.SelectedItem = null;
        }

        private void NewsLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NewsLongListSelector.SelectedItem == null)
                return;

            var list = App.ViewModel.NewsPage.EntryInformation;
            this.NavigationService.Navigate(new Uri("/News.xaml?goto=" + list.IndexOf((ViewModels.Entry)NewsLongListSelector.SelectedItem), UriKind.Relative));

            NewsLongListSelector.SelectedItem = null;
        }

        private void EmergenciesPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmergenciesPanel.SelectedItem == null)
                return;

            var phoneCall = new PhoneCallTask();
            ViewModels.Entry selected = (ViewModels.Entry)EmergenciesPanel.SelectedItem;

            phoneCall.DisplayName = selected.EntryName;
            phoneCall.PhoneNumber = selected.EntryPhoneNum;

            phoneCall.Show();

            EmergenciesPanel.SelectedItem = null;
        }

    }
}