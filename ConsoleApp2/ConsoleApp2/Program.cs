// See https://aka.ms/new-console-template for more information

using ConsoleApp2.Models;
using static ConsoleApp2.Repositories.PersonRepository;
using static ConsoleApp2.Repositories.PetRepository;




//AddPerson("Doe", "John", age : 25);

//AddPet("twig", 5, PetType.Fish, 101);

//AddPetAndPerson("Doe", "Jane", age: 25, "Twinkee", 2, PetType.Cat);

//List<Person> people = GetAllPerson();
//foreach (Person person in people)
//{
//    Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName} {person.Age} {person.Address}");
//}

//List<Pet> pets = GetAllPets();
//foreach (Pet pet in pets)
//{
//    Console.WriteLine($"{pet.Id} {pet.Name} {pet.PetType}, owner : {pet.Person.FirstName} {pet.Person.LastName}");
//}

//Person person = GetPersonById(70);
//List<Pet> pets = person.Pets;
//Console.WriteLine(
//    $"id : {person.Id} \n" +
//    $"First name : {person.FirstName} \n" +
//    $"Last name : {person.LastName} \n" +
//    $"Age : {person.Age} \n" +
//    $"Address : {person.Address} \n" +
//    $"Pets : {string.Join(", ", pets.Select(x => x.Name))}");

//List<Pet> pets = GetPetsByType(PetType.Bird);
//foreach (Pet pet in pets)
//{
//    Console.WriteLine($"{pet.Id} {pet.Name} {pet.PetType}");
//}

//DeletePersonAndPets(101);

//EditPerson(102, "", "", 30);

List<Person> people = GetPersonByPetType(PetType.Bird);
foreach (Person person in people)
{
    Console.WriteLine($"{person.LastName} {person.FirstName}");
}