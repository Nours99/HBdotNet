using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table(nameof(Teacher))]
    public class Teacher : Person
    {
        public int Salary { get; set; }

        [Required]
        [StringLength(30)]
        public required string Discipline { get; set; }

        public Classroom? Classroom { get; set; }

        public int? ClassroomID { get; set; }
    }
}
