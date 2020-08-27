using MediatR;
using Services.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Cars.Queries
{
    // Request.
    public class GetAllCarsQuery : BaseRequest, IRequest<IEnumerable<Car>> { }

    // Handler.
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        // Do DI if needed. May want to inject a db context in here.
        public GetAllCarsQueryHandler()
        {

        }

        // Handle method.
        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            // some business logic;
            return new[]
            {
                new Car { Name = $"Corvette - {request.UserId}" },
                new Car { Name = "Mazda 3" },
            };
        }
    }
}
