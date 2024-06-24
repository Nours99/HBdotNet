// See https://aka.ms/new-console-template for more information


using Interfaces;
using Models;
using System;
using static Tools.ConsoleTools;


ExoLinq();


//1.Affichez « Hello » et « World » sur 2 lignes séparés
void Exo1()
{
    Console.WriteLine("Hello\nWorld");
}


//2.Créez 2 fonctions dans votre classe, une pour récupérer l’entrée utilisateur en chaine de caractère et l’autre pour récupérer un entier. 
/*
string GetStringFromConsole(string question)
{
    Console.WriteLine(question);

    string input = Console.ReadLine();

    return input;
}

int GetIntFromConsole(string question)
{
    Console.WriteLine(question);

    string input = Console.ReadLine();

    if (int.TryParse(input, out int convertInput))
    {
        return convertInput;
    }
    else
    {
        Console.WriteLine("wrong number entered");
        return 0;
    }
}
*/


//3.Faites rentrez 3 mots à l’utilisateur et afficher les dans l’ordre inverse de la saisie
void Exo3()
{
    string word1 = GetStringFromConsole("Enter word 1?");
    string word2 = GetStringFromConsole("Enter word 2?");
    string word3 = GetStringFromConsole("Enter word 3?");

    Console.WriteLine(word3);
    Console.WriteLine(word2);
    Console.WriteLine(word1);
}


//4.Affichez si les 2 nombres rentrés par l’utilisateur sont égaux
void Exo4()
{
    int number1 = GetIntFromConsole("Enter number 1?");
    int number2 = GetIntFromConsole("Enter number 2?");

    if (number1 == number2)
    {
        Console.WriteLine("numbers are equals");
    }
    else
    {
        Console.WriteLine("numbers are différents");
    }
}

//5.Créez 2 nombres, les afficher, les intervertir avec une variable temporaire et les réafficher
void Exo5()
{

}

//6.Affichez le résultat de l’ajout, la soustraction, la multiplication et la division de 2 nombres 
void Exo6()
{
    int number1 = GetIntFromConsole("Enter number 1 ?");
    int number2 = GetIntFromConsole("Enter number 2 ?");

    Console.WriteLine((number1 + number2) + " " + (number1 - number2) + " " + (number1 * number2) + " " + (number1 / number2));
}

//7. Affichez la moyenne de 4 nombres rentrés par l’utilisateur
void Exo7()
{
    int number1 = GetIntFromConsole("Enter number 1 ?");
    int number2 = GetIntFromConsole("Enter number 2 ?");
    int number3 = GetIntFromConsole("Enter number 3 ?");
    int number4 = GetIntFromConsole("Enter number 4 ?");

    Console.WriteLine((number1 + number2 + number3 + number4) / 4);
}

//8. Affichez le nombre le plus grand de 4 nombres rentrés par l’utilisateur
void Exo8()
{
    int number1 = GetIntFromConsole("Enter number 1 ?");
    int number2 = GetIntFromConsole("Enter number 2 ?");
    int number3 = GetIntFromConsole("Enter number 3 ?");
    int number4 = GetIntFromConsole("Enter number 4 ?");

    int number5 = number1;

    if (number2 > number5)
    {
        number5 = number2;
    }
    if (number3 > number5)
    {
        number5 = number3;
    }
    if (number4 > number5)
    {
        number5 = number4;
    }

    Console.WriteLine(number5);

}

//9. Savoir si le nombre rentré est négatif ou positif
void Exo9()
{
    int number = GetIntFromConsole("Enter a number");

    if (number > 0)
    {
        Console.WriteLine(number + " Is greater than 0");
    }
    else if (number < 0)
    {
        Console.WriteLine(number + " Is lower than 0");
    }
    else
    {
        Console.WriteLine(number + " Is equal to 0");
    }
}

//10. Savoir si le nombre donné est pair ou impair
void Exo10()
{
    int number = GetIntFromConsole("Enter a number");

    if (number % 2 == 0)
    {
        Console.WriteLine(number + " Is even");
    }
    else
    {
        Console.WriteLine(number + " Is odd");
    }
}

//11.Rentrez un nombre en Celsius et le convertir en Kelvin (celsius + 273.15) et Fahrenheit (celsius * 18 / 10 + 32)
void Exo11()
{
    int celsius = GetIntFromConsole("Enter a temperature");

    Console.WriteLine(celsius + "° is equal to " + (celsius + 273.15) + "° Kelvin and " + (celsius * 18 / 10 + 32) + "° Fahrenheit");
}

//12. Rentrez un chiffre et dire de quel jour il s’agit sous forme de texte avec un switch (1 => lundi, etc.)
void Exo12()
{
    int number = GetIntFromConsole("Enter a number between 1-7");
    string jour = "";

    switch (number)
    {
        case 1: jour = "Monday"; break;
        case 2: jour = "Tuesday"; break;
        case 3: jour = "Wednesday"; break;
        case 4: jour = "Thursday"; break;
        case 5: jour = "Friday"; break;
        case 6: jour = "Saturday"; break;
        case 7: jour = "Sunday"; break;
        default: jour = "Wrong number entered"; break;
    }

    Console.WriteLine(jour);
}

//13. Rentrez un jour et dire de quel chiffre il s’agit (Lundi => 1, etc.)
void Exo13()
{
    string day = GetStringFromConsole("Enter a week day");
    int number = 0;

    switch (day)
    {
        case "Monday": number = 1; break;
        case "Tuesday": number = 2; break;
        case "Wednesday": number = 3; break;
        case "Thursday": number = 4; break;
        case "Friday": number = 5; break;
        case "Saturday": number = 6; break;
        case "Sunday": number = 7; break;
        default: Console.WriteLine("Wrong day entered"); break;
    }

}

//14. Rentrez un nombre, puis un signe (+ - * /), puis un autre nombre, affichez ensuite le résultat de l’opération (avec un switch)
void Exo14()
{
    int number1 = GetIntFromConsole("Enter a number ");
    int number2 = GetIntFromConsole("Enter a number again");
    string symbol = GetStringFromConsole("Enter a symbol (+ - * /)");

    switch (symbol)
    {
        case "+": Console.WriteLine(number1 + number2); break;
        case "-": Console.WriteLine(number1 - number2); break;
        case "*": Console.WriteLine(number1 * number2); break;
        case "/": Console.WriteLine(number1 / number2); break;
        default: Console.WriteLine("Wrong entry"); break;
    }
}

//15.Afficher les 10 premiers chiffres à partir de 0 (avec une boucle for)
void Exo15()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }
}

//16. Donnez la table de multiplication des 10 premiers chiffres
void Exo16()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine($"{i} x {j} = " + (i * j));
        }
    }
}

//17. Rentrez une lettre et une taille et l’afficher sous forme de triangle (bien nommer ses variables et faire du debug si ce n’est pas le bon résultat attendu) - optionnel
void Exo17()
{

}

//20. Créez la date d’aujourd’hui et affichez-la de façon complète puis de façon jour/mois/année
void Exo20()
{
    DateTime date = DateTime.Now;

    Console.WriteLine(date.ToString());

    Console.WriteLine(date.ToShortDateString());

}

//21. Créer une date avec l’utilisateur qui rentre l’année, mois, jour, heure, minute et seconde
//et afficher le jour (Lundi, mardi…) | en français ou en anglais
void Exo21()
{
    string question = "What year ?";
    string Question2 = "What month ?";
    string question3 = "What day ?";

    int year = GetIntFromConsole(question);
    int month = GetIntFromConsole(Question2);
    int day = GetIntFromConsole(question3);

    DateTime date = new DateTime(year, month, day);

    Console.WriteLine(date.ToString());
    Console.WriteLine(date.DayOfWeek);

}

//22. Affichez la différence de temps entre 2 dates avec une soustraction
void Exo22()
{
    DateTime date1 = DateTime.Now;
    DateTime date2 = new DateTime(1956, 12, 25);

    TimeSpan timeSpan = date1 - date2;
    Console.WriteLine(timeSpan.TotalDays);
}

//23. Convertir une chaine de caractère en date
void Exo23()
{
    string dateString = "2024/12/25";
    DateTime date;

    if (DateTime.TryParse(dateString, out date))
    {
        Console.WriteLine(date);
    }
}

//24. Jeu du plus ou moins (un nombre est définit par défaut, puis l’utilisateur rentre un chiffre et
//le programme lui dit si le bon nombre est + ou – que celui définit jusqu’à que l’utilisateur
//trouve)

void Exo24()
{
    int val = 42;
    int userVal = GetIntFromConsole("Enter a number");

    while (val != userVal)
    {
        if (userVal > val)
        {
            userVal = GetIntFromConsole($"Enter a number < {userVal}");
        }
        else if (userVal < val)
        {
            userVal = GetIntFromConsole($"Enter a number > {userVal}");
        }
    }

    Console.WriteLine($"Good Job! the right answer was {val}");
}

//25. Affichez une chaine donnée en majuscule
void Exo25()
{
    string userString = "mouhahahahahahahahaha !!";

    Console.WriteLine(userString.ToUpper());
}

//26. Créez une chaine de caractère « hello », remplacez les « l » par des « 1 » via la méthode
//Replace et affichez le résultat
void Exo26()
{
    string hello = "hello";

    Console.WriteLine($"{hello} --> {hello.Replace('l', '1')}");
}

//27. Savoir si la chaine de caractère rentrée par l’utilisateur contient la lettre « x » via la méthode Contains
void Exo27()
{
    string val = GetStringFromConsole("Write something... anything... really!");

    bool containX = val.Contains("x");

    if (containX)
    {
        Console.WriteLine("The sentence contain \"x\"");
    }
    else
    {
        Console.WriteLine("The sentence doesn't contain \"x\"");
    }
}

//28. Dire si une chaine est égale à une autre sans prendre en compte la casse
void Exo28()
{
    string q = "Gess the word";
    string input = GetStringFromConsole(q);

    if (string.Equals(input, "anticonstitutionnellement", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("Good job");
    }
    else
    {
        Console.WriteLine("Booooo! too bad");
    }
}

//29. Savoir si la chaine donnée est un palindrome (mot qui se lit dans les deux sens : SOS) sans
//méthode reverse, juste avec un for
void Exo29()
{
    string word = GetStringFromConsole("Give me a word");

    for (int i = 0; i < word.Length / 2; i++)
    {
        char c = word[i];
        char c2 = word[word.Length - 1 - i];

        if (c != c2)
        {
            Console.WriteLine("Nop");
            break;
        }
    }
}

/*
30. Lister les nombres de 1 à 100, en remplaçant le nombre par un mot selon certaines
conditions
a. Le mot Fizz s'il est multiple de 3
b. Le mot Buzz s'il est multiple de 5
c. Le mot FizzBuzz s'il est multiple de 3 et de 5
d. Un retour à la ligne tous les 9 éléments
*/
void Exo30()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.Write("FizzBuzz ");
        }
        else if (i % 3 == 0)
        {
            Console.Write("Fizz ");
        }
        else if (i % 5 == 0)
        {
            Console.Write("Buzz ");
        }
        else
        {
            Console.Write(i + " ");
        }

        if (i % 10 == 9)
            Console.WriteLine();
    }
}

//33. Dans votre programme créez une personne avec des valeurs rentrées par l’utilisateur, appelez la méthode créée précédemment et afficher la personne en console
//34. Créez 1 Personne, l’affecter à une autre variable Personne, les afficher, appeler la méthode MajPrenom sur la première personne et les réafficher. Que se passe - t - il au niveau des prénoms ?
void Exo34()
{
    string lastNameInput = GetStringFromConsole("Enter a last name (Nom)");
    string firstNameInput = GetStringFromConsole("Enter a first name (Prénom)");
    string birthdayInput = GetStringFromConsole("Enter a birthday (dd/mm/yyyy)");

    DateOnly birthday;
    DateOnly.TryParse(birthdayInput, out birthday);

    Person person = new Person()
    {
        LastName = lastNameInput,
        FirstName = firstNameInput,
        Birthday = birthday
    };

    Person person2 = person;

    Console.WriteLine("Without the Upper method : ");
    Console.WriteLine($"Person 1 = {person.LastName} {person.FirstName} {person.Birthday}");
    Console.WriteLine($"Person 2 = {person2.LastName} {person2.FirstName} {person2.Birthday}");

    person.FirstNameToUpper();

    Console.WriteLine();
    Console.WriteLine("With the Upper method : ");
    Console.WriteLine($"Person 1 = {person.LastName} {person.FirstName} {person.Birthday}");
    Console.WriteLine($"Person 2 = {person2.LastName} {person2.FirstName} {person2.Birthday}");
}

//35.Créez une propriété statique Test dans la classe Personne avec une valeur par défaut et l’afficher
void Exo35()
{
    Console.WriteLine(Person.Test);
}

//Héritage && polymorphisme
void ExoHeritage()
{
    List<Vehicle> vehicle = new List<Vehicle>();
    vehicle.Add(new Car() { Brand = "Renault", Name = "Mégane", DoorsNbr = 3 });
    vehicle.Add(new Car() { Brand = "Peugeot", Name = "3008", DoorsNbr = 5 });
    vehicle.Add(new Motorcycle() { Brand = "Peugeot", Name = "103", WheelsNbr = 2 });
    vehicle.Add(new Motorcycle() { Brand = "Can-Am", Name = "Spider", WheelsNbr = 3 });

    foreach (Vehicle v in vehicle)
    {
        Console.WriteLine(v.ShowDetails());
    }
}

void Exo37()
{
    Person[] people = new Person[4];
    people[0] = new Person() { LastName = "DOE", FirstName = "John", Birthday = DateOnly.Parse("01/01/2000") };
    people[1] = new Person() { LastName = "DOE", FirstName = "Jane", Birthday = DateOnly.Parse("10/10/2222") };
    people[2] = new Employee { LastName = "SKYWALKER", FirstName = "Luke", Salary = 1987.25 };
    people[3] = new Employee { LastName = "KENOBI", FirstName = "Obiwan", Salary = 99999999999.99 };

    IHumain[] iPeople = new IHumain[4];
    iPeople[0] = new Person() { LastName = "DOE", FirstName = "John" };
    iPeople[1] = new Person() { LastName = "DOE", FirstName = "Jane" };
    iPeople[2] = new Employee { LastName = "SKYWALKER", FirstName = "Luke", Salary = 1987.25 };
    iPeople[3] = new Employee { LastName = "KENOBI", FirstName = "Obiwan", Salary = 99999999999.99 };

    Console.WriteLine("Tab de Person avec methode Afficher()");

    foreach (Person person in people)
    {
        Console.WriteLine(person.Afficher());
    }

    Console.WriteLine();
    Console.WriteLine("Tab de IHumain avec methode ToString()");

    foreach (IHumain iPerson in iPeople)
    {
        Console.WriteLine(iPerson.ToString());
    }
}

//----------------------------------------------------------------EXO LINQ----------------------------------------------------------------

void ExoLinq()
{
    List<int> list = new List<int> { 2, 8, 6, 4, 15, 24, 84, 96, 35, 75, 24 };

    List<Person> people = new List<Person>
    {
        new Person { LastName = "DOE", FirstName = "John", Birthday = DateOnly.Parse("01/01/2000") },
        new Person { LastName = "DOE", FirstName = "Jane", Birthday = DateOnly.Parse("10/10/2222") },
        new Employee { LastName = "SKYWALKER", FirstName = "Luke", Salary = 1987.25 },
        new Employee { LastName = "KENOBI", FirstName = "Obiwan", Salary = 99999999999.99 },
        new Person { LastName = "DOE", FirstName = "John", Birthday = DateOnly.Parse("01/01/2000") },
        new Person { LastName = "DOE", FirstName = "Jane", Birthday = DateOnly.Parse("10/10/2222") },
        new Employee { LastName = "SKYWALKER", FirstName = "Luke", Salary = 1987.25 },
        new Employee { LastName = "KENOBI", FirstName = "Obiwan", Salary = 99999999999.99 },
        new Person { LastName = "DOE", FirstName = "John", Birthday = DateOnly.Parse("01/01/2000") },
        new Person { LastName = "Dupont", FirstName = "Christine", Birthday = DateOnly.Parse("01/04/1970") },
        new Employee { LastName = "SKYWALKER", FirstName = "Luke", Salary = 1987.25 },
        new Employee { LastName = "KENOBI", FirstName = "Obiwan", Salary = 99999999999.99 }
    };



    //1. Afficher la somme
    int sum = list.Sum();
    Console.WriteLine("Somme = " + sum);
    Console.WriteLine();


    //2. Afficher la moyenne

    double average = list.Average();
    Console.WriteLine("Moyenne = " + average);
    Console.WriteLine();


    //3. Sélectionner que les nombres qui sont > 6
    var supList = list.Where(x => x > 6);
    foreach (int i in supList)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    Console.WriteLine();


    //4. Compter le nombre d’élément
    int count = list.Count();

    Console.WriteLine("Total = " + count);
    Console.WriteLine();


    //5. Les trier avec la méthode OrderBy par le nom puis le prénom
    var aPeople = people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();

    foreach (Person person in aPeople)
    {
        Console.WriteLine($"{person.LastName} {person.FirstName}");
    }
    Console.WriteLine();


    //6. Afficher que les personnes qui ont leurs noms qui commence par D
    var dPeople = people.Where(a => a.LastName.StartsWith("D"));

    foreach (Person person in dPeople)
    {
        Console.WriteLine($"{person.LastName} {person.FirstName}");
    }
    Console.WriteLine();


    //7. Afficher que les noms des personnes
    var personName = people.Select(p => new { p.LastName });

    foreach (var person in personName)
    {
        Console.WriteLine($"{person.LastName}");
    }
    Console.WriteLine();


    //8. Récupérer que les 2 première personne
    var twoFirst = people.Take(2).ToList();

    foreach (var person in twoFirst)
    {
        Console.WriteLine(person.ToString());
    }
    Console.WriteLine();


    //9. Récupérer les personnes rentrées en 7ème 8ème et 9ème position
    var skipPeople = people.Skip(6).Take(3).ToList();

    foreach (var person in skipPeople)
    {
        Console.WriteLine(person.ToString());
    }
    Console.WriteLine();


    //10. Récupérer la personne qui a le nom Dupont
    Person dup = people.FirstOrDefault(a => a.LastName == "Dupont");

    Console.WriteLine(dup);
    Console.WriteLine();


    //11. Savoir si notre liste contient une personne dont le nom commence par D
    var startD = people.FirstOrDefault(a=> a.LastName.StartsWith("D"));

    Console.WriteLine(startD);
    Console.WriteLine();


    //12. Faire la somme du nombre de lettre dans les prénoms




}