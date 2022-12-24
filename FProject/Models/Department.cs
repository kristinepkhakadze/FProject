using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SemesterId { get; set; }
        public Semester Semester { get; set; }
        public int MaxNumofStudent { get; set; }
        public int CurrAmount { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
