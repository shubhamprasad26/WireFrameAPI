using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WireFrame.Model
{
    public class BookFlight
    {
        public int Id { get; set; }
        //public string flightname { get; set; }
        //public bool oneWay { get; set; }
        //public bool TwoWay { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime journeyDate { get; set; }
        public string Meals { get; set; }

    }
}
