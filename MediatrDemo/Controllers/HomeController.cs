using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Cars.Commands;
using Services.Cars.Queries;
using Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatrDemo.Controllers
{
    [ApiController]
    [Route("cars")]
    public class HomeController
    {
        // Mediatr.
        private readonly IMediator _mediatr;

        public HomeController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public Task<IEnumerable<Car>> Index()
        {            
            return _mediatr.Send(new GetAllCarsQuery());
        }

        [HttpPost]
        public Task<Response<Car>> Index([FromBody] CreateCarCommand command)
        {
            return _mediatr.Send(command);
        }
    }
}
