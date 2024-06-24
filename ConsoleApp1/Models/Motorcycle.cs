using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Motorcycle : Vehicle
    {
        public int WheelsNbr { get; set; }

        public override string ShowDetails()
        {
            return (base.ShowDetails() + $", nombre de roues : {WheelsNbr}");
        }
    }
}
