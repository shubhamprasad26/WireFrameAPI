using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WireFrame.Model;
using WireFrames.Model;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace WireFrames.BL
{
    public class AirlinesDataAccess : IAirlines
    {
        static int inc = 0;
        private readonly AppDbContext _context;
        public int airlineId = 1;
        public AirlinesDataAccess(AppDbContext context)
        {
            _context = context;

        }

        public List<Airlines> GetAllAirlines()
        {
            return _context.airliness.ToList<Airlines>();
        }

        public Airlines GetAirLineById(int id)
        {
            return _context.airliness.FirstOrDefault(air => air.Id == id);
        }

        public int AddAirlines(string airlnce)
        {
            Airlines aa = new Airlines();
            aa.F_Name = airlnce;
            try
            {
                _context.Add(aa);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return 0;
            }

        }
        public int DeleteAirLines(string AirlineName)
        {
            List<Airlines> allAir = GetAllAirlines();
            Airlines airDel;

            try
            {
                foreach (Airlines a in allAir)
                {
                    if (a.F_Name.ToLower() == AirlineName.ToLower())
                    {
                        airDel = GetAirLineById(a.Id);
                        _context.airliness.Remove(airDel);
                        _context.SaveChanges();
                        return 1;
                    }

                }
                return 2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return 0;
            }

        }

        public List<Places> Source()
        {
            return _context.placess.ToList();
        }

        public List<Places> Destinations(Places po)
        {
            Places p = _context.placess.FirstOrDefault(p => p.plcs == po.plcs);
            if(p==null)
            {
                return null;
            }
            //Places pp = _context.placess.FirstOrDefault(p => p.plcs == p.plcs);
            int ids = p.Id;
            List<Places> pqr = new List<Places>();
            List<Places> all = Source();
            foreach (Places op in all)
            {
                if (op.Id == ids) { continue; }
                else
                {
                    pqr.Add(op);
                }
            }
            return pqr;

        }

        public int AddPlaces(string plc)
        {
            try
            {
                _context.placess.Add(new Places() { plcs = plc });
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }

        }

        public List<Meals> AllOptions()
        {
            return _context.mealss.ToList();
        }

        public int AddMeals(string eat)
        {
            try
            {
                Meals mm = new Meals() { MealType = eat };
                _context.Add(mm);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return 0;
            }
            
        }

        public int DeleteMenu(string eat)
        {
            Meals mm = _context.mealss.FirstOrDefault(a => a.MealType == eat);
            if(mm==null)
            {
                return 0;
            }
            _context.mealss.Remove(mm);
            _context.SaveChanges();
            return 1;
        }

        public List<ScheduleType> scheduleTypes()
        {
            return _context.scheduleTypess.ToList();
        }

        public int AddSchedule(string schd)
        {
            try
            {
                var sch = new ScheduleType() { schType = schd.ToUpper() };
                _context.Add(sch);
                _context.SaveChanges();
                return 1;
            }
            catch
            {

                return 0;
            }
        }

        public int DeleteSchedule(string abc)
        {
            var aa = scheduleTypes();
            ScheduleType scc;
            try
            {
                foreach (ScheduleType sc in aa)
                {
                    if (sc.schType == abc.ToUpper())
                    {
                        int id = sc.Id;
                        scc = GetScheduleById(id);
                        _context.scheduleTypess.Remove(scc);
                        _context.SaveChanges();
                        return 1;
                    }
                }
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.StackTrace);
                return 2;
            }
            return 0;
        }
        public ScheduleType GetScheduleById(int id)
        {
            var abc = _context.scheduleTypess.FirstOrDefault(a => a.Id == id);
            return abc;
        }

        public FlightInfo AddAirlineInfo(FlightInfo flinfo)
        {
            
            FlightInfo finfo = new FlightInfo()
            {
                airline = flinfo.airline,
                cost = flinfo.cost,
                source = flinfo.source,
                destination = flinfo.destination,
                startDate = DateTime.Now.AddDays(50),
                endDate = DateTime.Now.AddDays(50).AddHours(2),
                flightNumber = flinfo.airline.Substring(0, 3).ToUpper()+inc,
                instrumentUsed = flinfo.instrumentUsed,
                logo = flinfo.logo,
                mealType = flinfo.mealType,
                businessSeats = flinfo.businessSeats,
                nonBusinessSeats = flinfo.nonBusinessSeats,
                noofRows = flinfo.noofRows,
                scheduleTypes = flinfo.scheduleTypes,
                briefInfo = flinfo.briefInfo,
            };
            inc++;
            //string abc = flinfo.flightNumber;
            //char aa = abc[3];


            //inc = Convert.ToInt32(aa) + 1;
            

             _context.flightInfos.Add(finfo);
             _context.SaveChanges();
            return finfo;
        }

        public int AddUser(Registration src)
        {
            try
            {
                //Registration rgr = new Registration() { };
                _context.Add(src);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.StackTrace);
                return 0;
            }
            
        }

        public List<FlightInfo> AllAirlineDetails()
        {
            return _context.flightInfos.ToList();
        }
        public int RemoveUser(int id)
        {
            try
            {
                var aa = _context.registrations.FirstOrDefault(a => a.Id == id);
                _context.registrations.Remove(aa);
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public  List<Login> Login(Login usr)
        {
            List<Login> a = new List<Login>();
            Login abc;
            try
            {
                var aa = _context.registrations.FirstOrDefault(a => a.Email == usr.email && a.password == usr.password);
                if(aa==null)
                {
                    abc = new Login();
                    abc.email = "Error";
                    abc.password = "Error";
                    abc.returnValue = 4;
                    a.Add(abc);
                    return a;

                }
                abc = new Login();
                abc.email = aa.Email;
                abc.password = aa.password;
                if(aa.isUser)
                {
                    abc.returnValue = 1;
                    a.Add(abc);
                }
                else if(!aa.isUser)
                {
                    abc.returnValue = 2;
                    a.Add(abc);
                }
                else
                {
                    abc.returnValue = 3;
                    a.Add(abc);
                }
                return a.ToList<Login>();
                

            }
            catch(Exception ee)
            {
                abc = new Login();
                abc.returnValue = 4;
                a.Add(abc);
                return a;
            }
            
        }

        public List<Registration> AllRegisteredUser()
        {
            return _context.registrations.ToList();
        }

        public void RemoveAirlineById(string id)
        {
            var aa = _context.flightInfos.FirstOrDefault(a => a.flightNumber == id);
            _context.flightInfos.Remove(aa);
            _context.SaveChanges();

        }

        public void AddUserFlights(userFlights usr)
        {
            try
            {
                _context.userflights.Add(usr);
                _context.SaveChanges();
                

            }
            catch
            {
                
            }
        }
        public List<FlightInfo> searchFlights(BookFlight abc)
        {
            List<FlightInfo> aa = _context.flightInfos.Where(a => a.source == abc.From && a.destination == abc.To ).ToList<FlightInfo>();
            return aa;
        }

        public int AddCoupon(Discount disc)
        {
            try
            {
                var abc = _context.discounts.FirstOrDefault(a => a.CouponCode.ToUpper() == disc.CouponCode.ToUpper());
                if (abc == null)
                {
                    _context.discounts.Add(disc);
                    _context.SaveChanges();
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch(Exception )
            {
                return 2;
            }
        }

        public int RetrieveDiscount(Discount scc)
        {
            try
            {
                var aa = _context.discounts.FirstOrDefault(a => a.CouponCode.ToUpper() == scc.CouponCode.ToUpper());
                if(aa == null)
                {
                    return 0;
                }
                return aa.Percentage;
            }
            catch(Exception )
            {
                return 0;
            }
            

        }
    }
}
