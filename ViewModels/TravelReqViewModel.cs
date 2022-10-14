using FTRRequestPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTRRequestPortal.ViewModels
{
    public class TravelReqViewModel
    {
        //emp gcm travel city country traveldeatils
        public Employee Employee { get; set; }

        public GCM GCM { get; set; }

        public Travel Travel { get; set; }

        //public City City { get; set; }

        //public Country Country { get; set; }

        public Travel_Details Travel_Details { get; set; }

        public List<City> Citys { get; set; }
        public List<Country> countries { get; set; }

        public TravelReqViewModel()
        {
            Citys = new List<City>();
            countries = new List<Country>();
        }
    }      
    
}