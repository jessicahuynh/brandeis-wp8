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
    }
}