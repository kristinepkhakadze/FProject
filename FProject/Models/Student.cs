using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int SemesterId { get; set; }
        public int PersonalId { get; set; }
        public int StartYear { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string? AddressId { get; set; }
        public Address  Address { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; }
        public int StudentSubjectId { get; set; }
        public int BalanceId { get; set; }
        public Balance Balance { get; set; }


    }
}
