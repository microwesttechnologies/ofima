using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Repositories
{
    public interface IUpdateEmployeeRepository
    {
        void Update(Employee employee);
    }
}
