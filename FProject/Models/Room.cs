using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Room
    {
        public int Id { get; set; } 
        public string? Description { get; set; }
        public bool IsFree { get; set; }    
        public int MaxNumberOfStudent { get; set; }
    }
}
