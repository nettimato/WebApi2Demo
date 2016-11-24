using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Demo.Models;

namespace WebApi2Demo.Controllers
{
    //tämän kontrollin tehtävänä on palauttaa metodin avulla kaikki autot metodilla GetAllCars ja yksittäinen auto ID:n perusteella metodilla GetCar
    public class CarsController : ApiController
    {
        Car[] cars = new Car[]
        {
            //new Car {Id=1, Name="Audi", Model="A4", Price=3999 },
            //new Car {Id=2, Name="Mersu", Model="H8374", Price=4999 },
            //new Car {Id=3, Name="Opel", Model="420", Price=5999 }
            new Car {Id=1, Name="Audi", Model="A4", Price=24000, Url="http://buyersguide.caranddriver.com/media/assets/submodel/7085.jpg"},
            new Car {Id=2, Name="Audi", Model="A6", Price=29000, Url="http://www.autowiki.fi/images/3/30/Audi_A6_2.0_TDI_%28C7%29_%E2%80%93_Frontansicht.jpg"},
            new Car {Id=3, Name="BMW", Model="320", Price=22000, Url="http://www.nettiauto.com/extra/images/bmw-320-2.jpg"},
            new Car {Id=4, Name="Volvo", Model="V70", Price=47000, Url="http://www.nettiauto.com/extra/images/volvo-v70-3.jpg"}
        };
        public IEnumerable<Car> GetAllCars()
        {
            return cars;
        }
        public IHttpActionResult GetCar(int id)
        {
            var car = cars.FirstOrDefault((p) => p.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }
    }
}
