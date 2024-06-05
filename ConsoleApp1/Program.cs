/*using ConsoleApp1.Factory;

var FactoryGiorgi = new ConcreteCreator_Giorgi();
var firstwarrior = FactoryGiorgi.CreateConcreteProduct();


var FactoryGodzila = new ConcreteCreator_Godzila();
var firstgodzila = FactoryGodzila.CreateConcreteProduct();

Console.Write(firstgodzila.Name);
Console.Write(firstwarrior.Name);*/

/////////////

using System.ComponentModel;
using ConsoleApp1.AbstractFactory.Creator;
using ConsoleApp1.Singleton;

/*
var AFactory = new A_FamilyCreator();
var BFactory = new B_FamilyCreator();

var AGodzila = AFactory.CreateWarrior();
var AMed = AFactory.CreateMed();

var BGodzila = BFactory.CreateWarrior();
var BMed = BFactory.CreateMed();
*/

/*Console.WriteLine(AGodzila.Level + " " + " " + BGodzila.Level + " " + " " + AMed.HelpLevel + " " + " " + BMed.HelpLevel);*/


var typo = CarSingleton.CreateCarObject();