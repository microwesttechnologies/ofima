using MediatR;
using Domain.Services.Repositories;

namespace Application.Service.EmployeeFeature.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int IdentificationCard { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string DateOfAdmission { get; set; }
        public int Cargo { get; set; }
        public string State { get; set; }

        public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, Unit>
        {
            private readonly IUpdateEmployeeRepository UpdateEmployeeRepository;
            private readonly IGetEmployeeByIdRepository GetEmployeeByIdRepository;
            private readonly IUnitOfWork UnitOfWork;

            public UpdateEmployeeCommandHandler(IUpdateEmployeeRepository updateEmployeeRepository, IGetEmployeeByIdRepository getEmployeeByIdRepository, IUnitOfWork unitOfWork)
            {
                UpdateEmployeeRepository = updateEmployeeRepository;
                GetEmployeeByIdRepository = getEmployeeByIdRepository;
                UnitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
            {
                var employee = await GetEmployeeByIdRepository.GetEmployeeById(request.Id);

                if(employee == null)
                {
                    throw new Exception("Not Find Employee");
                }

                employee.Name = request.Name;
                employee.IdentificationCard = request.IdentificationCard;
                employee.Picture = request.Picture;
                employee.DateOfAdmission = request.DateOfAdmission;
                employee.Cargo = request.Cargo;
                employee.State = request.State;

                UpdateEmployeeRepository.Update(employee);
                await UnitOfWork.SaveChanges();

                return Unit.Value;
            }


        }
    }
}
