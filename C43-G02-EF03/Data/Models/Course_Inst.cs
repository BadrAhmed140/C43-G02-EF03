using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF03.Data.Models
{
    internal class Course_Inst
    {

        [Key, Column(Order = 0)]
        [ForeignKey("Instructor")]
        public int inst_ID { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public float Evaluate { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
