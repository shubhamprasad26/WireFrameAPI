using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WireFrame.Model
{
    public class userFlights
    {
        public int Id { get; set; }
        public string logo { get; set; }
        public String Flight_Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int price { get; set; }
        public DateTime takeOfDate { get; set; }
    }
}
