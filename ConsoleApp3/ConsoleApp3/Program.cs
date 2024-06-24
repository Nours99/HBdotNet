// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Loader;


LocationContext context = new LocationContext();


Program();


//////////////////////////////////////////////////////////////////////////////////CLIENT/////////////////////////////////////////////////////////////////////////////////////

List<Client> ListAll()
{
    List<Client> clientList = context.Clients.ToList();

    foreach (Client client in clientList)
    {
        Console.WriteLine($"id : {client.Id}; Nom : {client.Nom}; Prénom : {client.Prenom}");
    }

    return clientList;
}

Client FindClientById(int id)
{
    Client client = context.Clients.FirstOrDefault(c => c.Id == id);

    Console.WriteLine($"id : {client.Id}; Nom : {client.Nom}; Prénom : {client.Prenom}");

    return client;
}

List<Client> ListClientByName(string name)
{
    List<Client> clientList = context.Clients.Where(c => c.Nom == name).ToList();

    foreach (Client client in clientList)
    {
        Console.WriteLine($"id : {client.Id}; Nom : {client.Nom}; Prénom : {client.Prenom}");
    }

    return clientList;
}

void CreateClient(string firstName, string lastName, String date)
{
    context.Clients.Add(new Client
    {
        Nom = firstName,
        Prenom = lastName,
        DateNaissance = DateOnly.Parse(date)
    });

    context.SaveChanges();

    ListClientByName(firstName);
}

void DeleteClientByName(string firstName)
{
    context.Clients.Remove(context.Clients.FirstOrDefault(c => c.Nom == firstName));
    context.SaveChanges();

    ListAll();
}

void DeleteClientById(int id)
{
    context.Clients.Remove(context.Clients.FirstOrDefault(c => c.Id == id));
    context.SaveChanges();

    ListAll();
}

void ModifyClient(int id, string name)
{
    Client client = FindClientById(id);

    client.Nom = name;
    context.SaveChanges();

    FindClientById(id);
}

/////////////////////////////////////////////////////////////////////////////////////LOCATION////////////////////////////////////////////////////////////////////////////////

List<Location> ListAllLocation()
{
    List<Location> list = context.Locations.Include(c => c.IdClientNavigation).ToList();

    foreach (Location location in list)
    {
        Console.WriteLine($"{location.Id} {location.DateDebut} - {location.DateFin}; {location.IdClientNavigation.Nom} {location.IdClientNavigation.Prenom}");
    }

    return list;
}

Location FindLocationById(int id)
{
    Location? location = context.Locations.Include(c => c.IdClientNavigation).Include(v=>v.IdVehiculeNavigation).FirstOrDefault(l => l.Id == id);

    Console.WriteLine($"{location.Id} {location.DateDebut} - {location.DateFin}; {location.IdClientNavigation.Nom} {location.IdClientNavigation.Prenom}, {location.IdVehiculeNavigation.Immatriculation}");

    return location;
}

void Program()
{
    //ListAll();
    //FindClientById(12);
    //ListClientByName("Long");
    //CreateClient("DOE", "John", "10/10/2000");
    //DeleteClientById(51);
    //ModifyClient(51, "Doe");
    //ListAllLocation();
    FindLocationById(12);

}