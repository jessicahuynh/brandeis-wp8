﻿using System;
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
    public partial class Links : PhoneApplicationPage
    {
        public Links()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.OpenInBrowser("");
        }
    }
}