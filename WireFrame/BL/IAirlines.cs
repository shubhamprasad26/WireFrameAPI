using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WireFrames.Model;
using WireFrame.Model;

namespace WireFrames.BL
{
    public interface IAirlines
    {
        List<Airlines> GetAllAirlines();
        Airlines GetAirLineById(int id);
        int AddAirlines(string airlnce);
        int DeleteAirLines(string AirlineName);
        List<Places> Source();
        List<Places> Destinations(Places p);
        int AddPlaces(string plc);

        List<Meals> AllOptions();
        int AddMeals(string eat);
        int DeleteMenu(string eat);
        List<ScheduleType> scheduleTypes();
        int AddSchedule(string schd);

        int DeleteSchedule(string abc);
        FlightInfo AddAirlineInfo(FlightInfo flinfo);

        List<FlightInfo>  AllAirlineDetails();

        void RemoveAirlineById(string id);
        int AddUser(Registration src);

        List<Registration> AllRegisteredUser();
        int RemoveUser(int id);

        List<Login> Login(Login usr);
        void AddUserFlights(userFlights usr);
        List<FlightInfo> searchFlights(BookFlight anc);
        int AddCoupon(Discount disc);
        int RetrieveDiscount(Discount scc);

    }
}
