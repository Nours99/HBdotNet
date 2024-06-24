using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class Employee : Person
{
    public double Salary { get; set; }

    public override string Afficher()
    {
        return (base.Afficher() + $", Salaire : {Salary}");
    }

    public override string ToString()
    {
        return Afficher();
    }
}
