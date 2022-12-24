using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public int SemesterId { get; set; }
        public Semester Semester { get; set; }
        public int StudentId { get; set; }
        public  Student Student { get; set; }
        public float Debth { get; set; }
    }
}
