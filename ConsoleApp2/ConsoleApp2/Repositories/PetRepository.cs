using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Repositories.PersonRepository;

namespace ConsoleApp2.Repositories;

public class PetRepository
{
    static PetContext context = new PetContext();


    public static Pet AddPet(string name, int age, PetType petType, int PersonId)
    {
        Pet pet = new Pet
        {
            Name = name,
            Age = age,
            PetType = petType,
            PersonId = PersonId
        };

        context.Pets.Add(pet);
        context.SaveChanges();

        return pet;
    }

    public static void AddPetAndPerson(string firstName, string lastname, int age, string petName, int petAge, PetType petType)
    {
        Person person = AddPerson(firstName, lastname, age);

        AddPet(petName, petAge, petType, person.Id);
    }

    public static List<Pet> GetAllPets()
    {
        List<Pet> list = context.Pets.Include(p => p.Person).ToList();
        return list;
    }

    public static Pet GetPetById(int id)
    {
        return context.Pets.SingleOrDefault(x => x.Id == id);
    }

    public static void ChangePetOwner(int id, int newId)
    {
        Pet pet = GetPetById(id);
        pet.PersonId = newId;
        context.SaveChanges();
    }

    public static Pet GetPetByName(string name)
    {
        return context.Pets.SingleOrDefault(x => x.Name == name);
    }

    public static List<Pet> GetPetsByType(PetType type)
    {
        return context.Pets.Where(x => x.PetType == type).ToList();
    }

    

}
