using MediatR;
using Services.Models;
using Services.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Cars.Commands
{
    // Request.
    public class CreateCarCommand : IRequestWrapper<Car> { }

    // Handler.
    public class CreateCarCommandHandler : IHandlerWrapper<CreateCarCommand, Car>
    {
        public Task<Response<Car>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return Task.FromResult(Response.Fail<Car>("Already exists"));
            }

            return Task.FromResult(Response.Ok(new Car { Name = "Lincoln" }, "Car Created."));
        }
    }
}
