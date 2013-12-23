using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace BrandeisMobile
{
    public partial class DirectoryLinks : PhoneApplicationPage
    {
        public DirectoryLinks()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string strItemIndex;

            if (NavigationContext.QueryString.TryGetValue("goto", out strItemIndex))
                Directory.SelectedIndex = Convert.ToInt32(strItemIndex);
            
            base.OnNavigatedTo(e);

        }

        private void ServicesPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ServicesPanel.SelectedItem == null)
                return;
            
            var phoneCall = new PhoneCallTask();
            ViewModels.Entry selected = (ViewModels.Entry)ServicesPanel.SelectedItem;

            phoneCall.DisplayName = selected.EntryName;
            phoneCall.PhoneNumber = selected.EntryPhoneNum;

            phoneCall.Show();

            ServicesPanel.SelectedItem = null;
        }

        private void AdmissionsPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AdmissionsPanel.SelectedItem == null)
                return;

            var phoneCall = new PhoneCallTask();
            ViewModels.Entry selected = (ViewModels.Entry)AdmissionsPanel.SelectedItem;

            phoneCall.DisplayName = selected.EntryName;
            phoneCall.PhoneNumber = selected.EntryPhoneNum;

            phoneCall.Show();

            AdmissionsPanel.SelectedItem = null;
        }

        private void CampusLocationsPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CampusLocationsPanel.SelectedItem == null)
                return;

            var phoneCall = new PhoneCallTask();
            ViewModels.Entry selected = (ViewModels.Entry)CampusLocationsPanel.SelectedItem;

            phoneCall.DisplayName = selected.EntryName;
            phoneCall.PhoneNumber = selected.EntryPhoneNum;

            phoneCall.Show();

            CampusLocationsPanel.SelectedItem = null;
        }
    }
}