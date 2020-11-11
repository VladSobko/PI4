using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR1ASP.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int MarkValue { get; set; }
        public int? StudentId { get; set; }
        public Student Student { get; set; }

    }
}