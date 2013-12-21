using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace BrandeisMobile.ViewModels
{
    public class Entry : INotifyPropertyChanged
    {
   
        public Entry(string n, string u = " ", string p = " ", string e = " ", string l = " ")
        {
            EntryName = n;
            EntryURL = u;
            EntryPhoneNum = p;
            EntryEmail = e;
            EntryLocation = l;
        }

        public string EntryName { get; set; }
        public string EntryURL { get; set; }
        public string EntryPhoneNum { get; set; }
        public string EntryEmail { get; set; }
        public string EntryLocation { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}