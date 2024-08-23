using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Entities
{
    internal class Department
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateOnly? HiringDate { get; set; }

        [InverseProperty("Department")]
        public ICollection<Student> Studentss { get; set; } = new HashSet<Student>();


         //**********************************************************//


        [InverseProperty("department")]
        public ICollection<Instructor> instructors {  get; set; } = new HashSet<Instructor>();

        //************************************************************//
        //[ForeignKey("department2")]
        //[InverseProperty("department2")]
        public Instructor? instructor2 { get; set; }
    }
}
