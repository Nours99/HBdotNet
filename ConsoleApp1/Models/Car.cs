using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car : Vehicle
    {
        public int DoorsNbr { get; set; }

        public override string ShowDetails()
        {
            return (base.ShowDetails() + $", Nombre de portes : {DoorsNbr}");
        }
    }
}
