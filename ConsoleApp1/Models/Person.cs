using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Models;

//31. Créez une classe Personne qui comporte trois propriétés, nom, prénom et date de naissance
//32. Ecrivez une méthode « MajPrenom » dans la classe Personne qui écrase l’ancien prénom par le prénom en majuscule
public class Person : IHumain
{
    public required string LastName { get; set; } //NOM
    public required string FirstName { get; set; } //PRENOM
    public DateOnly? Birthday { get; set; }
    public static string Test = "This is a test, don't panic!";

    public Person() { }
    public Person(string lastName, string firstName, DateOnly? birthday)
    {
        LastName = lastName;
        FirstName = firstName;
        Birthday = birthday;
    }

    public void FirstNameToUpper()
    {
        FirstName = FirstName.ToUpper();
    }

    public virtual string Afficher()
    {
        //return $"{LastName} {FirstName} {Birthday}";
        return string.Format("Nom : {0}, Prénom : {1}, Date de naissance : {2}", LastName, FirstName, Birthday);
    }

    public override string ToString()
    {
        return Afficher();
    }

}
