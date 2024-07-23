using MediatR;
using Domain.Services.Repositories;
using Domain.Model.Entities;



namespace Application.Service.EmployeeFeature.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int IdentificationCard { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string DateOfAdmission { get; set; }
        public int Cargo { get; set; }
        public string State { get; set; }
        public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
        {
            readonly ICreateEmployeeRepository Repository;
            readonly IUnitOfWork UnitOfWork;

            public CreateEmployeeCommandHandler(ICreateEmployeeRepository repository, IUnitOfWork unitOfWork)


            {
                Repository = repository;
                UnitOfWork = unitOfWork;
            }

            public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {
                var NewEmployee = new Employee
                {
                    Id = request.Id,
                    Name = request.Name,
                    Cargo = request.Cargo,
                    DateOfAdmission = request.DateOfAdmission,
                    IdentificationCard = request.IdentificationCard,
                    Picture = request.Picture,
                    State = request.State
                };
                Repository.Create(NewEmployee);
                await UnitOfWork.SaveChanges();

                return NewEmployee.Id;
            }
        }
    }
}
