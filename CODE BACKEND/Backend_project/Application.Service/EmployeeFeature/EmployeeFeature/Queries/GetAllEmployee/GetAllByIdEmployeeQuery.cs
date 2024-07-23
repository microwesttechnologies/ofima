using Domain.Services.Repositories;
using Domain.Model.Entities;
using MediatR;

namespace Application.Service.EmployeeFeature.Queries.GetEmployeeById
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int EmployeeId { get; }

        public GetEmployeeByIdQuery(int employeeId)
        {
            EmployeeId = employeeId;
        }

        public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
        {
            private readonly IGetEmployeeByIdRepository _repository;

            public GetEmployeeByIdQueryHandler(IGetEmployeeByIdRepository repository)
            {
                _repository = repository;
            }

            public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
            {
                var employee = await _repository.GetEmployeeById(request.EmployeeId);
                return employee;
            }
        }
    }
}
