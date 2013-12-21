using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandeisMobile.ViewModels
{
    // An entry, containing at least a name and url/phone number
    // Clickable
    public class Entry
    {
        public string EntryName { get; set; }
        public string EntryURL { get; set; }
        public string EntryPhoneNum { get; set; }
        public string EntryEmail { get; set; }
        public string EntryLocation { get; set; }
        public string EntryIcon { get; set; }
    }
}
