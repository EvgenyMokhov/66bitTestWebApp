using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Footballer
    {
        public int FootballerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Sex { get; set; }
        public DateOnly BornDate { get; set; }
        public int TeamId { get; set; }
        public string Country { get; set; }
    }
}
