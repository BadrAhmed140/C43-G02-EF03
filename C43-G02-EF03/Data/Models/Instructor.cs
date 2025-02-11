using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF03.Data.Models
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        public Department Department { get; set; }

        public ICollection<Course_Inst> Course_Insts { get; set; } = new List<Course_Inst>();
    }
}
