using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PassengerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        List<Passenger> passengerList = new List<Passenger>()
        {
            new Passenger() { passengerId=1 , passengerName = "John" , passengerGender="male" , passengerLocation="Pune" , passengerNumber=12344},
            new Passenger() { passengerId=2 , passengerName = "SMinth" , passengerGender="male" , passengerLocation="Bangalore" , passengerNumber=123564},
            new Passenger() { passengerId=3 , passengerName = "Mary" , passengerGender="female" , passengerLocation="Chennai" , passengerNumber=123114},
        };

        [HttpGet]

        public IEnumerable<Passenger> getAllPassengers() 
        {
            return passengerList;
        }

        [HttpPost]

        public List<Passenger> addPassenger(Passenger obj) 
        {
            passengerList.Add(obj);
            return passengerList;
            
        }

        [HttpPut]

        public List<Passenger> updatePassenger(Passenger obj) 
        {
            var objToDelete = passengerList.Find(item => item.passengerId == obj.passengerId);
            passengerList.Remove(objToDelete);
            passengerList.Add(obj);
            return passengerList;
        }
    }
}
