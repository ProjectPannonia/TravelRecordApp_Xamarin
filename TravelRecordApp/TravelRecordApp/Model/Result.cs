using System;
using System.Collections.Generic;
using System.Text;

namespace TravelRecordApp.Model
{
    public class Result
    {
        public string fsq_id { get; set; }

        public IList<Category> categories { get; set; }

        public IList<object> chains { get; set; }

        public int distance { get; set; }

        public Geocodes geocodes { get; set; }

        public Location location { get; set; }

        public string name { get; set; }

        public RelatedPlaces related_places { get; set; }

        public string timezone { get; set; }
    }
}
