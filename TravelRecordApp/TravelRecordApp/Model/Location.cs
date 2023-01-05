using System;
using System.Collections.Generic;
using System.Text;

namespace TravelRecordApp.Model
{
    public class Location
    {
        public string address { get; set; }

        public string country { get; set; }

        public string cross_street { get; set; }

        public string locality { get; set; }

        public string postcode { get; set; }

        public string region { get; set; }

        public IList<string> neighborhood { get; set; }
    }
}
