// See https://aka.ms/new-console-template for more information


using DesignPattern.AbstractFactory;
using DesignPattern.Builder;
using DesignPattern.Prototype;
using DesignPattern.Singleton;

//Singletone
Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

if (logger1 == logger1)
    Console.WriteLine("Same");



//builder
ConnectionStringBuilder connectionStringBuilder = new ConnectionStringBuilder("LocalHost");
connectionStringBuilder.AddUsernameAndPassword("demo", "1234");
connectionStringBuilder.AddTrustedConnection(false);
ConnectionString connectionString = connectionStringBuilder.GetConnectionString();
Console.WriteLine(connectionString.ConnectionStringItem.ToString());

//Prototype
Product product = new Product { Name = "Camera", Color = "Red", Price = 1400, Description = " this is for photography" };

Product product1 = product.Copy();

product.Name = "CANNON";

Console.WriteLine($"{product.Name},{product.Color},{product.Price},{product.Description}");
Console.WriteLine($"{product1.Name},{product1.Color},{product1.Price},{product1.Description}");




//Abstract Factory

FighterJetFactory fighterJetFactory = new MigFactory();

FighterJet f1 = fighterJetFactory.GetJet();

Weapon weapon1 = fighterJetFactory.GetWeapon();

Pilot pilot1 = fighterJetFactory.GetPilot();


FighterJetFactory fighterJetFactory1 = new F16Factory();

FighterJet f2 = fighterJetFactory1.GetJet();

Weapon weapon2 = fighterJetFactory1.GetWeapon();

Pilot pilot2 = fighterJetFactory1.GetPilot();


Console.WriteLine(pilot2._pilotname);

