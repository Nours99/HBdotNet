using Dal;
using DomainModel;
using System;

//TestDB();

Queries();

void TestDB()
{
    Classroom classroom = new Classroom
    {
        Name = "test",
        Floor = 2,
        Corridor = "Blue"
    };

    using (SchoolContext context = new()) //Disposable
    {
        // Delete database
        context.Database.EnsureDeleted();
        //// Create database
        context.Database.EnsureCreated();

        ////Add classroom
        //context.Add(classroom);

        //// Update classroom
        //classroom = context.Classrooms.FirstOrDefault(r => r.ClassroomID == 1);
        //classroom.Name = "Denver";
        //context.Update(classroom);

        // Delete classroom
        //context.Remove(context.Classrooms.FirstOrDefault(r => r.ClassroomID == 1));

        // Apply changes
        //context.SaveChanges();
    };

}

void Queries()
{
    using (SchoolContext context = new())
    {
        // Affichez toutes les personnes
        var people = context.People;
        foreach (Person person in people)
            Console.WriteLine($"{person.PersonID}, {person.FirstName}, {person.LastName}");
        Console.WriteLine("------------------------------------------------");

        // Affichez tous les étudiants
        var students = context.Students;
        foreach (Person student in students)
            Console.WriteLine($"{student.PersonID}, {student.FirstName}, {student.LastName}");
        Console.WriteLine("------------------------------------------------");

        // Affichez la personne ayant la clé primaire égale à 2
        var personWithId = context.People.FirstOrDefault(p => p.PersonID == 2);
        Console.WriteLine($"{personWithId.PersonID}, {personWithId.FirstName}, {personWithId.LastName}");
        Console.WriteLine("------------------------------------------------");

        // Filtrez et affichez les personnes ayant un âge supérieur ou égal à 30 ans
        var thirties = context.People.Where(p => p.Age >= 30);
        foreach (Person person in thirties)
            Console.WriteLine($"{person.PersonID}, {person.FirstName}, {person.LastName}, {person.Age}");
        Console.WriteLine("------------------------------------------------");

        // Récupérez et affichez la première personne de la liste qui a un âge supérieur à 30 ans
        var thirty = context.People.FirstOrDefault(p => p.Age >= 30);
        Console.WriteLine($"{thirty.PersonID}, {thirty.FirstName}, {thirty.LastName}, {thirty.Age}");
        Console.WriteLine("------------------------------------------------");

        //§ Récupérez et affichez la dernière personne de la liste qui a un âge supérieur à 30 ans
        var lastThirty = context.People.OrderBy(x => x.PersonID).LastOrDefault(p => p.Age >= 30);
        Console.WriteLine($"{lastThirty.PersonID}, {lastThirty.FirstName}, {lastThirty.LastName}, {lastThirty.Age}");
        Console.WriteLine("------------------------------------------------");

        // Récupérez et affichez la seule personne qui a plus de 60 ans
        var sixty = context.People.FirstOrDefault(s => s.Age > 60);
        Console.WriteLine($"{sixty.PersonID}, {sixty.FirstName}, {sixty.LastName}, {sixty.Age}");
        Console.WriteLine("------------------------------------------------");

        // Affichez la liste triée par prénoms
        var orderedPeople = context.People.OrderBy(p => p.FirstName);
        foreach (Person person in orderedPeople)
            Console.WriteLine($"{person.PersonID}, {person.FirstName}, {person.LastName}");
        Console.WriteLine("------------------------------------------------");

        // Affichez la liste triée par âge, puis par nom en tri secondaire, puis par prénom en tri tertiaire
        var orderedPeopleAgain = context.People.OrderBy(p => p.Age).ThenBy(p => p.LastName).ThenBy(p => p.FirstName);
        foreach (Person person in orderedPeopleAgain)
            Console.WriteLine($"{person.PersonID}, {person.FirstName}, {person.LastName}, {person.Age}");
        Console.WriteLine("------------------------------------------------");
    }



}
