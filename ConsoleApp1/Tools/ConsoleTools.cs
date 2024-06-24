using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tools;

public class ConsoleTools
{
    //36. Mettre les 2 méthodes créées au début dans l’exercice 2 (GetStringFromConsole et GetIntFromConsole) dans une classe statique et adapter le code existant
    public static string GetStringFromConsole(string question)
    {
        Console.WriteLine(question);

        string input = Console.ReadLine();

        return input;
    }

    public static int GetIntFromConsole(string question)
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
}
