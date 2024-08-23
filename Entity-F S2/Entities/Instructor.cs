using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Entities
{
    internal class Instructor
    {
        public int InstId { get; set; }
        public string Name { get; set; }
        public int? Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        [InverseProperty("instructors")]
        public Department? department { get; set; }

        //****************************************//

        //[InverseProperty("instructor2")]
        //public Department department2 { get; set; }

    }
}
