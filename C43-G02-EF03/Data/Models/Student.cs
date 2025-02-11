using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF03.Data.Models
{
    internal class Student
    {

        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FName { get; set; }

        [Required, MaxLength(50)]
        public string LName { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new List<Stud_Course>();
    }
}
