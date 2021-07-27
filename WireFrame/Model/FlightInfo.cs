using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WireFrames.Model
{
    public class FlightInfo
    {
        public int Id { get; set; }
        public string flightNumber { get; set; }
        public string airline { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string logo { get; set; }
        public string scheduleTypes { get; set; }
        public string instrumentUsed { get; set; }
        public int businessSeats { get; set; }
        public int nonBusinessSeats { get; set; }
        public decimal cost { get; set; }
        public byte noofRows { get; set; }
        public string mealType { get; set; }
        public string briefInfo { get; set; }

        public bool schedule { get; set; }
    }
}
