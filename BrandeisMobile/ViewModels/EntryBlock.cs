using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandeisMobile.ViewModels
{
    public class EntryBlock
    {
        public EntryBlock()
        {
            EntryInformation = new List<Entry>();
        }

        public string Title { get; set; }
        public List<Entry> EntryInformation { get; set; }


    }
}
