using MediatR;
using Domain.Services.Repositories;


namespace Application.Service.EmployeeFeature.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<bool>
    {
        public int EmployeeId { get; set; }

        public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
        {
            private readonly IDeleteEmployeeRepository _repository;
            private readonly IUnitOfWork _unitOfWork;

            public DeleteEmployeeCommandHandler(IDeleteEmployeeRepository repository, IUnitOfWork unitOfWork)
            {
                _repository = repository;
                _unitOfWork = unitOfWork;
            }

            public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
            {
                var employee = await _repository.Delete(request.EmployeeId);

                if (employee == null)
                {
                    return false;
                }
                await _unitOfWork.SaveChanges();

                return true; //TODO VALIDAR METODO
            }
        }
    }
}
