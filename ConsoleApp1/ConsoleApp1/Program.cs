// See https://aka.ms/new-console-template for more information



Exo16();


//1.Affichez « Hello » et « World » sur 2 lignes séparés
void Exo1()
{
    Console.WriteLine("Hello");
    Console.WriteLine("world");
}


//2.Créez 2 fonctions dans votre classe, une pour récupérer l’entrée utilisateur en chaine de caractère et l’autre pour récupérer un entier. 
string GetStringInput(string question)
{
    Console.WriteLine(question);

    string input = Console.ReadLine();

    return input;
}

int GetIntInput(string question)
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


//3.Faites rentrez 3 mots à l’utilisateur et afficher les dans l’ordre inverse de la saisie
void Exo3()
{
    string word1 = GetStringInput("Enter word 1?");
    string word2 = GetStringInput("Enter word 2?");
    string word3 = GetStringInput("Enter word 3?");

    Console.WriteLine(word3);
    Console.WriteLine(word2);
    Console.WriteLine(word1);
}


//4.Affichez si les 2 nombres rentrés par l’utilisateur sont égaux
void Exo4()
{
    int number1 = GetIntInput("Enter number 1?");
    int number2 = GetIntInput("Enter number 2?");

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
    int number1 = GetIntInput("Enter number 1 ?");
    int number2 = GetIntInput("Enter number 2 ?");

    Console.WriteLine((number1 + number2) + " " + (number1 - number2) + " " + (number1 * number2) + " " + (number1 / number2));
}

//7. Affichez la moyenne de 4 nombres rentrés par l’utilisateur
void Exo7()
{
    int number1 = GetIntInput("Enter number 1 ?");
    int number2 = GetIntInput("Enter number 2 ?");
    int number3 = GetIntInput("Enter number 3 ?");
    int number4 = GetIntInput("Enter number 4 ?");

    Console.WriteLine((number1 + number2 + number3 + number4) / 4);
}

//8. Affichez le nombre le plus grand de 4 nombres rentrés par l’utilisateur
void Exo8()
{
    int number1 = GetIntInput("Enter number 1 ?");
    int number2 = GetIntInput("Enter number 2 ?");
    int number3 = GetIntInput("Enter number 3 ?");
    int number4 = GetIntInput("Enter number 4 ?");

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
    int number = GetIntInput("Enter a number");

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
    int number = GetIntInput("Enter a number");

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
    int celsius = GetIntInput("Enter a temperature");

    Console.WriteLine(celsius + "° is equal to " + (celsius + 273.15) + "° Kelvin and " + (celsius * 18 / 10 + 32) + "° Fahrenheit");
}

//12. Rentrez un chiffre et dire de quel jour il s’agit sous forme de texte avec un switch (1 => lundi, etc.)
void Exo12()
{
    int number = GetIntInput("Enter a number between 1-7");
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
    string day = GetStringInput("Enter a week day");
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
    int number1 = GetIntInput("Enter a number ");
    int number2 = GetIntInput("Enter a number again");
    string symbol = GetStringInput("Enter a symbol (+ - * /)");

    switch (symbol)
    {
        case "+": Console.WriteLine(number1 + number2); break;
        case "-": Console.WriteLine(number1 - number2); break;
        case "*": Console.WriteLine(number1 * number2); break;
        case "/": Console.WriteLine(number1 / number2); break;
        default : Console.WriteLine("Wrong entry");break;
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
            Console.WriteLine(i*j);
        }
    }
}

//17. Rentrez une lettre et une taille et l’afficher sous forme de triangle (bien nommer ses variables et faire du debug si ce n’est pas le bon résultat attendu) - optionnel
void Exo17()
{

}