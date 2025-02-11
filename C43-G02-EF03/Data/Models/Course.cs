using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF03.Data.Models
{
    internal class Course
    {

        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public int Duration { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new List<Stud_Course>();
        public ICollection<Course_Inst> Course_Insts { get; set; } = new List<Course_Inst>();
    }
}
