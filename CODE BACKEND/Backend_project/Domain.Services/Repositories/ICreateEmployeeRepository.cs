using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;

namespace Domain.Services.Repositories
{
    public interface ICreateEmployeeRepository
    {
        void Create(Employee employee);
    }
}
