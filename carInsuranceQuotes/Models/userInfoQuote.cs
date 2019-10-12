using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace carInsuranceQuotes.Models
{
    public class userInfoQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int Tickets { get; set; }
        public double BasePolicy { get; set; }
        public bool Dui { get; set; }
        public bool FullCoverage { get; set; }
        public double Quotes { get; set; }
    }
}