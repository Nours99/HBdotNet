// See https://aka.ms/new-console-template for more information


public class Animal
{
    public string nom;

    public int age;

    public Animal(string nom, int age)
    {
        this.nom = nom;
        this.age = age;
    }

    public void AfficherInfo()
    {
        Console.WriteLine($"Je suis un animal nomé {nom}, et j'ai {age} ans");
    }

    protected void AjouterUnAn()
    {
        age++;
    }
}

public class Chat : Animal
{
    public Chat(string nom, int age) : base(nom, age)
    {

    }

    public void Cri()
    {
        Console.WriteLine("Miaou");
    }

    public void FeterAnniversaire()
    {
        this.AjouterUnAn();
        Console.WriteLine("Joyeux anniversaire");
    }
}






public class Program
{
    public static void Main()
    {
        Animal monanimal = new Animal("bob", 15);
        monanimal.AfficherInfo();

        Chat monchat = new Chat("Bobby", 15);
        monchat.AfficherInfo(); 
        monchat.Cri();
        monchat.FeterAnniversaire();
        monchat.AfficherInfo();
    }
}