using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriverService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        List<Driver> driverList = new List<Driver>()
        {
            new Driver() { driverId=1 , driverName = "Driver1" , driverGender="male" , driverLocation="Pune" , driverNumber=12344},
            new Driver() { driverId=2 , driverName = "Driver2" , driverGender="male" , driverLocation="Bangalore" , driverNumber=123564},
            new Driver() { driverId=3 , driverName = "Driver3" , driverGender="female" , driverLocation="Chennai" , driverNumber=123114},
        };

        [HttpGet]

        public IEnumerable<Driver> getAllDrivers()
        {
            return driverList;
        }

        [HttpPost]

        public List<Driver> addDriver(Driver obj)
        {
            driverList.Add(obj);
            return driverList;

        }

        [HttpPut]

        public List<Driver> updateDriver(Driver obj)
        {
            var objToDelete = driverList.Find(item => item.driverId == obj.driverId);
            driverList.Remove(objToDelete);
            driverList.Add(obj);
            return driverList;
        }

    }
}
