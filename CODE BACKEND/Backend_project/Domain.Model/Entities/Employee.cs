using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

using System;

namespace Domain.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int IdentificationCard { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string DateOfAdmission { get; set; }
        public int Cargo { get; set; }
        public string State { get; set; }
        public Employee()
        {
            Name = string.Empty;
            Picture = string.Empty;
            DateOfAdmission = string.Empty;
            State = string.Empty;
        }
    }
}

