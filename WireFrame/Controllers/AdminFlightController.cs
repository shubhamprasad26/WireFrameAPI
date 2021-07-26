using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WireFrames.Model;
using WireFrames.BL;
using WireFrame.Model;
using System.Threading;

namespace WireFrames.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminFlightController : ControllerBase
    {
        private readonly IAirlines _air;
        public AdminFlightController(IAirlines air)
        {
            _air = air;
        }
        [HttpGet]
        public IActionResult GetAllAirlines()
        {
            var air = _air.GetAllAirlines();
            if (air == null)
            {
                return NotFound("Currently Airline List is empty");
            }
            return Ok(air);

        }
        [HttpPost]
        public IActionResult AddANewAirLine(string aa)
        {
            var airs = _air.AddAirlines(aa);
            if (airs == 0)
            {
                return NotFound("Unable to add");
            }
            return Ok("Added a New Airlines");
        }
        [HttpDelete]
        [Route("api/[controller]/{name}")]
        public IActionResult DeleteAirLines(string name)
        {
            int ans = _air.DeleteAirLines(name);
            string msg;
            if (ans == 1)
            {
                msg = "Successfully Deleted " + name + " from Existing Record";
                return Ok(msg);
            }
            else if (ans == 2)
            {
                msg = "Requested " + name + " is not present in our record to delete";
                return NotFound(msg);
            }
            else if (ans == 0)
            {
                msg = "Some Exception Occured";
                return NotFound(msg);
            }
            return NotFound();

        }
        [HttpPost]
        public IActionResult AddPlaces(string cityName)
        {
            var aa = _air.AddPlaces(cityName);
            return Ok("Added new place");
        }
        [HttpGet]
        public IActionResult ViewAllLocation()
        {
            var src = _air.Source();
            return Ok(src);
        }
        [HttpPost]
        public IActionResult Destinations(Places abc)
        {
            var dest = _air.Destinations(abc);
            return Ok(dest);
        }
        [HttpPost]
        public IActionResult AddMeals(string mnu)
        {
            int mrs = _air.AddMeals(mnu);
            if (mrs == 1)
                return Ok(mrs);
            return NotFound("Some Error Occurs");
        }
        [HttpGet]
        public IActionResult Menu()
        {
            var mrs = _air.AllOptions();
            if (mrs != null)
                return Ok(mrs);
            return NotFound("Some Error Occurs");
        }
        [HttpDelete]
        public IActionResult RemoveAMillCategory(string abc)
        {
            int optn = _air.DeleteMenu(abc);
            if (optn == 0) { return Ok(optn); }
            return NotFound(abc + " is not a valid option to remove please check once");

        }
        [HttpPost]
        public IActionResult AddSchedule(string aa)
        {
            var schd = _air.AddSchedule(aa);
            if (schd == 1)
            {
                return Ok("Successfully added the schedule in record");
            }
            else
            {
                return NotFound("SOme issue occured to add records");
            }

        }
        [HttpGet]
        public IActionResult ShowAllSchedule()
        {
            var ans = _air.scheduleTypes();
            return Ok(ans);
        }
        [HttpDelete]
        public IActionResult DeleteASchedule(string delsch)
        {
            var abc = _air.DeleteSchedule(delsch);
            if (abc == 1)
            {
                return Ok("Successfully deleted record from our Database");
            }
            return NotFound("Some error occurs while removing record from databse");
        }
        [HttpPost]
        public IActionResult AdminAddAirlines(FlightInfo aii)
        {
            var airls = _air.AddAirlineInfo(aii);
            if (airls == null) { return NotFound("Some Error Occured while adding airlines"); }
            return Ok(airls);
        }
        [HttpPost]
        //[Route("{src}")]
        public IActionResult Registration(Registration src)
        {
            var aa = _air.AddUser(src);
            if (aa == 1)
            {
                return Ok(1);
            }
            return Ok(2);
        }
        [HttpGet]
        public IActionResult AllFlights()
        {
            var aa = _air.AllAirlineDetails();
            return Ok(aa);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteUserFromDb(int id)
        {
            var aa = _air.RemoveUser(id);
            if (aa == 1) { return Ok("Successfully removed record from DB"); }
            return NotFound("Unable to remove user from record");
        }
        [HttpPost]
        public IActionResult  Login(Login usr)
        {
            try
            {
                var a =  _air.Login(usr);

                if (a[0].returnValue ==3 || a[0].returnValue==4)
                {
                    return Ok(a);
                }
                else
                {
                    return Ok(a);
                }
            }
            catch(Exception e)
            {
                return NotFound(2);
            }
        }
        [HttpGet]
        public List<Registration> AllRegisteredUser()
        {
            var abc = _air.AllRegisteredUser();
            return abc;
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult RemoveAirlineByIds(string id)
        {
            try
            {
                _air.RemoveAirlineById(id);
                return Ok("Successfully removed the airlines from our Records..");
            }
            catch
            {
                return NotFound("THis Airline can not be deleted");
            }
        }
        [HttpPost]
        public IActionResult adduserFlights(userFlights abc)
        {
            try
            {
                _air.AddUserFlights(abc);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult searchFlights(BookFlight abc)
        {
            var aa = _air.searchFlights(abc);
            if(aa!=null)
            {
                return Ok(aa);
            }
            return NotFound("SOme issue occured");
        }
        [HttpPost]
        public IActionResult addCoupon(Discount disc)
        {
            try
            {
                
                var abc = _air.AddCoupon(disc);
                if (abc == 0)
                {
                    return Ok(0);
                }
                else
                {
                    return Ok(2);
                }
            }
            catch (Exception)
            {
                return Ok(2);
            }
        }
        [HttpPost]
        public IActionResult knowDiscount(Discount abc)
        {
            try
            {
                var abcd = _air.RetrieveDiscount(abc);
                return Ok(abcd);

            }
            catch(Exception)
            {
                return Ok(0);
            }
        }

    }
}
