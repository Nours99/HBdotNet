// See https://aka.ms/new-console-template for more information


public abstract class Vehicle
{
    public string Make;
    public string Model;
    public int Year;

    public Vehicle(string make, string model, int year)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }

    public abstract void DisplayInfo();

}


public class Car : Vehicle
{

    public Car(string make, string model, int year) : base(make, model, year)
    {

    }
    public override void DisplayInfo()
    {    
        Console.WriteLine($"Car: {Make}, {Model}, {Year}");
    }
}

public class Truck : Vehicle
{

    public Truck(string make, string model, int year) : base(make, model, year)
    {

    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck: {Make}, {Model}, {Year}");
    }
}

public class Motorcycle : Vehicle
{

    public Motorcycle(string make, string model, int year) : base(make, model, year)
    {

    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle: {Make}, {Model}, {Year}");
    }
}

public class VehicleFactory
{
    public static Vehicle CreateVehicle(string type, string make, string model, int year)
    {
        switch (type.ToLower())
        {
            case "car":
                return new Car(make, model, year);
            case "truck":
                return new Truck(make, model, year);
            case "motorcycle":
                return new Motorcycle(make, model, year);
            default:
                throw new ArgumentException("Choose a vehicle type");

        }        
    }
}


public class Program
{
    static void Main()
    {
        Vehicle car = VehicleFactory.CreateVehicle("car", "Renaut", "Mégane", 2000);
        Vehicle truck = VehicleFactory.CreateVehicle("truck", "bof", "Mouai", 2000);
        Vehicle motorcycle = VehicleFactory.CreateVehicle("motorcycle", "Kawazaki", "sais pas", 2000);

        car.DisplayInfo();
        truck.DisplayInfo();
        motorcycle.DisplayInfo();
    }
}