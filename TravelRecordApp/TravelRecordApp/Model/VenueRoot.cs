using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TravelRecordApp.Helpers;
using Xamarin.Forms;

namespace TravelRecordApp.Model
{
    public class VenueRoot
    {
        public static string GenerateUrl(double lat, double lon)
        {
            NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();

            nfi.NumberDecimalSeparator = ".";

            return string.Format(nfi, Constants.VENUE_SEARCH, lat, lon);
        }
        
    }
}
