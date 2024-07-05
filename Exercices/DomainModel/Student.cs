using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table(nameof(Student))]
    public class Student : Person
    {
        public double? Average { get; set; }
        public bool IsClassDelegate { get; set; }

        public Classroom? Classroom { get; set; }
        public int? ClassroomID { get; set; }
    }
}
