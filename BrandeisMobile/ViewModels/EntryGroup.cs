using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandeisMobile.ViewModels
{
    public class EntryGroup
    {
        public EntryGroup()
        {
            Items = new List<Entry>();
        }

        public List<Entry> Items { get; set; }
        public string EntryGroupTitle { get; set; }
    }
}
