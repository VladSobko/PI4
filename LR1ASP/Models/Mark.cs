using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR1ASP.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public string English { get; set; }
        public string Math { get; set; }
        public string WebProgramming { get; set; }
        public int StudentId { get; set; }
    }
}