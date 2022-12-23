using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int PersonalId { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } 
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        public int? SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
