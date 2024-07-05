using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table(nameof(Classroom))]
    public class Classroom
    {
        public int ClassroomID { get; set; }

        [Required]
        [StringLength(30)]
        [Column("classname")]
        public required string Name { get; set; }

        public int Floor { get; set; }

        public required string Corridor { get; set; }

        public ICollection<Student> Students { get; set; }

        public Teacher? Teacher { get; set; }
    }
}
