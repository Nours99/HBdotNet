using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Name { get; set; }

        public virtual string ShowDetails()
        {
            return $"Marque : {Brand}, Modèle : {Name}";
        }
    }
}
