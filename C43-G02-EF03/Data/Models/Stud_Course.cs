using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF03.Data.Models
{
    internal class Stud_Course
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Student")]
        public int stud_ID { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public float Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
