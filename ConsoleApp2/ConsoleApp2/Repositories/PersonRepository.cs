using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repositories;

public class PersonRepository
{
    static PetContext context = new PetContext();

    //Add Person (complete version)
    public static Person AddPerson(string firstName, string lastName, string? address, int age, string? phoneNumber)
    {
        Person person = new Person
        {
            FirstName = firstName,
            LastName = lastName,
            Address = address,
            Age = age,
            PhoneNumber = phoneNumber
        };

        context.Persons.Add(person);
        context.SaveChanges();

        return person;
    }
    //Add Person
    public static Person AddPerson(string firstName, string lastName, int age)
    {
        Person person = new Person
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age
        };

        context.Persons.Add(person);
        context.SaveChanges();

        return person;
    }

    //Get all Person
    public static List<Person> GetAllPerson()
    {
        return context.Persons.ToList();

    }

    //Get a Person by id with his pets        
    public static Person GetPersonById(int id)
    {
        return context.Persons.Include(x => x.Pets).FirstOrDefault(x => x.Id == id);
    }

    public static void DeletePersonAndPets(int id)
    {
        Person person = GetPersonById(id);
        context.Persons.Remove(person);
        context.SaveChanges();
    }

    public static void EditPerson(int id, string firstName, string lastName, int age)
    {
        Person person = context.Persons.FirstOrDefault(x => x.Id == id);

        if (person.FirstName != firstName && firstName != string.Empty)
        {
            person.FirstName = firstName;
        }
        if (person.LastName != lastName && lastName != string.Empty)
        {
            person.LastName = lastName;
        }
        if (person.Age != age)
        {
            person.Age = age;
        }

        context.SaveChanges();
    }

    public static List<Person> GetPersonByPetType(PetType type)
    {
        //return context.Pets.Include(x => x.Person).Where(x => x.PetType == type).ToList();

        return context.Persons.Include(x => x.Pets).Where(x => x.Pets.Any(p => p.PetType == type)).ToList();
    }

}
