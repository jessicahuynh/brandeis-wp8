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
    public partial class LibraryPage : PhoneApplicationPage
    {
        public LibraryPage()
        {
            InitializeComponent();

            ApplicationBar = ThemeManager.CreateApplicationBar();
            ApplicationBar.Mode = ApplicationBarMode.Default;
            ApplicationBar.Opacity = .8;
            ApplicationBar.IsVisible = true;
            ApplicationBar.IsMenuEnabled = true;

            ApplicationBarIconButton backIcon = new ApplicationBarIconButton();
            backIcon.IconUri = new Uri("/Images/back.png", UriKind.Relative);
            backIcon.Text = "previous";
            ApplicationBar.Buttons.Add(backIcon);
            backIcon.Click += new EventHandler(backBrowser_Click);

            ApplicationBarIconButton refreshIcon = new ApplicationBarIconButton();
            refreshIcon.IconUri = new Uri("/Images/refresh.png", UriKind.Relative);
            refreshIcon.Text = "refresh";
            ApplicationBar.Buttons.Add(refreshIcon);
            refreshIcon.Click += new EventHandler(refreshBrowser_Click);

            ApplicationBarIconButton forwardIcon = new ApplicationBarIconButton();
            forwardIcon.IconUri = new Uri("/Images/next.png", UriKind.Relative);
            forwardIcon.Text = "forward";
            ApplicationBar.Buttons.Add(forwardIcon);
            forwardIcon.Click += new EventHandler(forwardBrowser_Click);

            ApplicationBarMenuItem openInBrowser = new ApplicationBarMenuItem();
            openInBrowser.Text = "open in browser";
            ApplicationBar.MenuItems.Add(openInBrowser);
            openInBrowser.Click += new EventHandler(openInBrowser_Click);
        }

        private void refreshBrowser_Click(object sender, EventArgs e)
        {
            LibraryBrowser.Source = new Uri(LibraryBrowser.Source.ToString(), UriKind.Absolute);
        }

        private void backBrowser_Click(object sender, EventArgs e)
        {
            if (LibraryBrowser.CanGoBack)
                LibraryBrowser.GoBack();
        }

        private void forwardBrowser_Click(object sender, EventArgs e)
        {
            if (LibraryBrowser.CanGoForward)
                LibraryBrowser.GoForward();
        }

        private void openInBrowser_Click(object sender, EventArgs e)
        {
            App.OpenInBrowser(LibraryBrowser.Source.ToString());
        }
    }
}