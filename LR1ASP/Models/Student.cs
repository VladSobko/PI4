using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR1ASP.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int WebProgramming { get; set; }
    }
}