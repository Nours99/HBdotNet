

int[] tab = CreateArray();

ShowUnsortTab(tab);

Console.WriteLine("\n-------------------");

SortTab(tab);

ShowUnsortTab(tab);


// Affichange non trié
static void ShowUnsortTab(int[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.Write($"{tab[i]} ");
    }
}

// Affichage trié
void ShowSortTab()
{
    foreach (int i in tab)
    {
        Console.Write($"{i} ");
    }
}

// Tri
static void SortTab(int[] tab)
{
    int temp;
    bool isSwapped;

    do
    {
        isSwapped = false;

        for (int i = 0; i < tab.Length - 1; i++)
        {
            if (tab[i] > tab[i + 1])
            {
                temp = tab[i];
                tab[i] = tab[i + 1];
                tab[i + 1] = temp;

                isSwapped |= true;
            }
        }
    } while (isSwapped);
}

// Creation de tableau
static int[] CreateArray()
{
    Console.WriteLine("Array lenght?");

    String input = Console.ReadLine();
    int inputInt = 0;
    var x = int.TryParse(input, out inputInt);

    //int[] tab = { 9, 6, 8, 3, 4, 7, 1, 2, 5, 0 };
    int[] tab = new int[inputInt];

    Random random = new Random();

    for (int i = 0; i < tab.Length; i++)
    {
        tab[i] = random.Next(0, 200);
    }

    Console.WriteLine();

    return tab;
}