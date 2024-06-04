// See https://aka.ms/new-console-template for more information


public class DataBaseConnection
{
    private DataBaseConnection() { }

    private static DataBaseConnection Instance = null;
    private static readonly object Padlock = new object();

    public bool IsConnected;

    public static DataBaseConnection instance
    {
        get 
        {
            lock (Padlock)
            {
                if (Instance == null)
                {
                    Instance = new DataBaseConnection();
                }
                return Instance;
            }
        
        }
        
    }

    public void OpenConection()
    {
        IsConnected = true;     
        
        Console.WriteLine("Connection à la base de donnée");
    }

    public void CloseConection()
    {
        if (IsConnected)
        {
            IsConnected = false;
        }
        Console.WriteLine("Fermeture de la connection à la base de donnée ");
    }

    public class Program
    {
        public static void Main()
        {
            DataBaseConnection dataBaseConnection = DataBaseConnection.instance;

            dataBaseConnection.OpenConection();
            Console.WriteLine($"Etat de la connection : {dataBaseConnection.IsConnected}");

            dataBaseConnection.CloseConection();
            Console.WriteLine($"Etat de la connection : {dataBaseConnection.IsConnected}");
        }
    }

}
