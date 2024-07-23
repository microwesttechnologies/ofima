using Domain.Model.Entities;
using Domain.Services.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Service.EmployeeFeature.Queries.GetAllMenu
{
    public class GetAllMenuQuery : IRequest<IEnumerable<Menu>>
    {
    }

   
    public class GetAllMenuQueryHandler : IRequestHandler<GetAllMenuQuery, IEnumerable<Menu>>
    {
        private readonly IGetAllRepository _repository;

        
        public GetAllMenuQueryHandler(IGetAllRepository repository)
        {
            _repository = repository;
        }

       
        public async Task<IEnumerable<Menu>> Handle(GetAllMenuQuery request, CancellationToken cancellationToken)
        {
           
            var menus = await _repository.GetAll();

         
            return (IEnumerable<Menu>)menus;
        }
    }
}
