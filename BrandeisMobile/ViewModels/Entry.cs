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
    public class Entry
    {


        public string EntryName { get; set; }
        public string EntryURL { get; set; }
        public string EntryPhoneNum { get; set; }
        public string EntryFaxNum { get; set; }
        public string EntryEmail { get; set; }
        public string EntryLocation { get; set; }

    }
}