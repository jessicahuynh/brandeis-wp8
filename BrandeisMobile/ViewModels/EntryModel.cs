using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BrandeisMobile.Resources;

namespace BrandeisMobile.ViewModels
{
    public class EntryModel
    {
        public EntryBlock CampusServices { get; set; }
        public EntryBlock Admissions {get; set;}
        public EntryBlock CampusLocations {get; set;}
        public EntryBlock Links {get; set;}
        public EntryBlock LandingPage {get; set;}
        public EntryBlock NewsPage { get; set; }
        public EntryBlock Emergencies { get; set; }

        public EntryBlock NewsFeatures { get; set; }

        
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty { get; set; }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded { get; set; }
             

        public void LoadData()
        {
            LandingPage = CreateLandingPageList();
            NewsPage = CreateNewsPageList();

            Links = CreateLinksPageList();

            CampusServices = CreateCampusServicesList();
            Admissions = CreateAdmissionsList();
            CampusLocations = CreateCampusLocationsList();

            this.IsDataLoaded = true;
        }

        private EntryBlock CreateLandingPageList()
        {
            EntryBlock data = new EntryBlock();
            data.Title = "home";

            data.EntryInformation.Add(new Entry { EntryName = "library" });
            data.EntryInformation.Add(new Entry { EntryName = "athletics", EntryURL="/athletics.xaml" });
            data.EntryInformation.Add(new Entry { EntryName = "dining" });
            data.EntryInformation.Add(new Entry { EntryName = "photos" });
            data.EntryInformation.Add(new Entry { EntryName = "video" });
            data.EntryInformation.Add(new Entry { EntryName = "social" });

            return data;
        }

        private EntryBlock CreateNewsPageList()
        {
            EntryBlock data = new EntryBlock();
            data.Title = "news";

            data.EntryInformation.Add(new Entry { EntryName = "features" });
            data.EntryInformation.Add(new Entry { EntryName = "in the news" });
            data.EntryInformation.Add(new Entry { EntryName = "around campus" });
            data.EntryInformation.Add(new Entry { EntryName = "alumni" });
            data.EntryInformation.Add(new Entry { EntryName = "arts" });
            data.EntryInformation.Add(new Entry { EntryName = "athletics" });
            data.EntryInformation.Add(new Entry { EntryName = "business" });
            data.EntryInformation.Add(new Entry { EntryName = "humanities & social sciences" });
            data.EntryInformation.Add(new Entry { EntryName = "international affairs" });
            data.EntryInformation.Add(new Entry { EntryName = "research" });
            data.EntryInformation.Add(new Entry { EntryName = "science & technology" });
            data.EntryInformation.Add(new Entry { EntryName = "student life" });
            data.EntryInformation.Add(new Entry { EntryName = "blog: president Fred Lawrence" });
            data.EntryInformation.Add(new Entry { EntryName = "blog: science @ brandeis" });

            return data;
        }

        private EntryBlock CreateLinksPageList()
        {
            EntryBlock data = new EntryBlock();
            data.Title = "links";

            data.EntryInformation.Add(new Entry { EntryName = "Admissions, Undergraduate", EntryURL = "www.brandeis.edu/admissions" });
            data.EntryInformation.Add(new Entry { EntryName = "Graduate Professional Studies", EntryURL = "www.brandeis.edu/gps" });
            data.EntryInformation.Add(new Entry { EntryName = "Graduate School of Arts and Sciences", EntryURL = "www.brandeis.edu/gsas" });
            data.EntryInformation.Add(new Entry { EntryName = "The Heller School", EntryURL = "heller.brandeis.edu" });
            data.EntryInformation.Add(new Entry { EntryName = "International Business School", EntryURL = "www.brandeis.edu/global" });
            data.EntryInformation.Add(new Entry { EntryName = "LATTE", EntryURL = "www.brandeis.edu/latte" });
            data.EntryInformation.Add(new Entry { EntryName = "LTS", EntryURL = "lts.brandeis.edu" });
            data.EntryInformation.Add(new Entry { EntryName = "Registrar", EntryURL = "www.brandeis.edu/registrar" });
            data.EntryInformation.Add(new Entry { EntryName = "SAGE", EntryURL = "www.brandeis.edu/sage" });
            data.EntryInformation.Add(new Entry { EntryName = "Sports & Recreation Center", EntryURL = "www.brandeisjudges.com/facilities/schedule" });

            return data;
        }

        private EntryBlock CreateCampusServicesList()
        {
            EntryBlock data = new EntryBlock();
            data.Title = "services";

            data.EntryInformation.Add(new Entry { EntryName = "BranVan", EntryPhoneNum = "781-736-4999" });
            data.EntryInformation.Add(new Entry { EntryName = "Dial by Name", EntryPhoneNum = "781-736-5555" });
            data.EntryInformation.Add(new Entry { EntryName = "Technology Help Desk", EntryPhoneNum = "781-736-4357", EntryLocation = "Goldfarb Library" });
            data.EntryInformation.Add(new Entry { EntryName = "Voicemail", EntryPhoneNum = "781-736-2222" });

            return data;
        }

        private EntryBlock CreateAdmissionsList()
        {
            EntryBlock data = new EntryBlock();
            data.Title = "admissions";

            data.EntryInformation.Add(new Entry 
            { 
                EntryName = "Undergraduate", 
                EntryLocation = "Shapiro Admissions Center", 
                EntryPhoneNum = "781-736-3500", 
                EntryFaxNum = "781-736-3525", 
                EntryEmail = "admissions@brandeis.edu" 
            });
            data.EntryInformation.Add(new Entry
            {
                EntryName = "Graduate School of Arts and Sciences",
                EntryLocation = "Kutz Hall, Room 219",
                EntryPhoneNum = "781-736-3410",
                EntryFaxNum = "781-736-3412",
                EntryEmail = "gradschool@brandeis.edu"
            });
            data.EntryInformation.Add(new Entry
            { 
                EntryName = "Heller School", 
                EntryLocation = "Schneider Building", 
                EntryPhoneNum = "781-736-3820", 
                EntryFaxNum = "781-736-2774", 
                EntryEmail = "helleradmissions@brandeis.edu" 
            });
            data.EntryInformation.Add(new Entry
            {
                EntryName = "International Business School",
                EntryLocation = "Lemberg Academic Center, Room 150",
                EntryPhoneNum = "781-736-2252",
                EntryFaxNum = "781-736-2263",
                EntryEmail = "admission@lemberg.brandeis.edu"
            });
            data.EntryInformation.Add(new Entry
            {
                EntryName = "Graduate Professional Studies",
                EntryLocation = "Old South Street",
                EntryPhoneNum = "781-736-8787",
                EntryFaxNum = "781-736-3420",
                EntryEmail = "gps@brandeis.edu"
            });
            data.EntryInformation.Add(new Entry
            {
                EntryName = "Summer and Continuing Studies",
                EntryLocation = "Old South St, second floor",
                EntryPhoneNum = "781-736-3424",
                EntryFaxNum = "781-736-8124",
                EntryEmail = "summerschool@brandeis.edu"
            });

            return data;
        }

        private EntryBlock CreateCampusLocationsList()
        {
            EntryBlock data = new EntryBlock();
            data.Title = "locations";

            data.EntryInformation.Add(new Entry { EntryName = "Mailing Address", EntryLocation = "415 South St. Waltham, MA 02453-2578", EntryPhoneNum = "781-736-2000" });
            data.EntryInformation.Add(new Entry { EntryName = "Alumni Relations", EntryLocation = "Bernstein Marcus", EntryPhoneNum = "800-333-1948" });
            data.EntryInformation.Add(new Entry { EntryName = "Athletics", EntryLocation = "Gosman Sports and Convocations Center", EntryPhoneNum = "781-736-3630" });
            data.EntryInformation.Add(new Entry { EntryName = "Brandeis Bookstore", EntryLocation = "Shapiro Campus Center (SCC)", EntryPhoneNum = "781-736-4272", EntryFaxNum = "781-736-4895" });
            data.EntryInformation.Add(new Entry { EntryName = "Brandeis Tickets", EntryLocation = "SCC", EntryPhoneNum = "781-736-3400", EntryURL = "go.brandeis.edu/BrandeisTickets" });
            data.EntryInformation.Add(new Entry { EntryName = "Community Living", EntryLocation = "Usdan Student Center", EntryPhoneNum = "781-736-5060" });
            data.EntryInformation.Add(new Entry { EntryName = "Conference and Events", EntryLocation = "Kutz Hall, Room 9", EntryPhoneNum = "781-736-4300", EntryFaxNum = "781-736-4318", EntryEmail = "ces@brandeis.edu" });

            return data;
        }
    }
}