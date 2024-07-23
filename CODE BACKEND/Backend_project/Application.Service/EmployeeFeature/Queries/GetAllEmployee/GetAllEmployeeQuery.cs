using Domain.Model.Entities;
using Domain.Services.Repositories;
using MediatR;


namespace Application.Service.EmployeeFeature.Queries.GetAllEmployee
{
    public class GetAllEmployeeQuery: IRequest<IEnumerable<Employee>>
    {
        public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<Employee>>
        {
            private readonly IGetAllRepository Repository;

            public GetAllEmployeeQueryHandler(IGetAllRepository repository)
            {
                Repository = repository;
            }

            public async Task<IEnumerable<Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
            {
                var employees = await Repository.GetAll();

                return employees;
            }
        }
    }
}
