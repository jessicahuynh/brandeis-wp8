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
    public partial class News : PhoneApplicationPage
    {
        public News()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";

                if (NavigationContext.QueryString.TryGetValue("goto", out selectedIndex))
                    NewsPivot.SelectedIndex = Convert.ToInt32(selectedIndex);

                base.OnNavigatedTo(e);
            }
        }
    }
}