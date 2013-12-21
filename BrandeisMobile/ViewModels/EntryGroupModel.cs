using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandeisMobile.ViewModels
{
    public class EntryGroupModel
    {
        public EntryGroup Emergencies { get; set; }
        public EntryGroup CampusServices { get; set; }
        public EntryGroup Admissions { get; set; }
        public EntryGroup CampusLocations { get; set; }
        public EntryGroup Links { get; set; }
    }
}
