using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Model
{
    internal class Classroom
    {
        public int ClassroomID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Floor { get; set; }
        public string Corridor { get; set; } = string.Empty;
    }
}
