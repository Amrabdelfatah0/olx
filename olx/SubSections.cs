using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olx
{
 public class SubSections:Sections
    {
        public string model { get; set; }
        public DateOnly modelDate { get; set; }
        public string description { get; set; }
        public Sections sections { get; set; }  ?
    }
}
