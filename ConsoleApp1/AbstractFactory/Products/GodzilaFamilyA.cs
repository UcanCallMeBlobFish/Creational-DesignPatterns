namespace ConsoleApp1.AbstractFactory.Products;

public class GodzilaFamilyA : IWarrior
{
    public string Name { get; set; }
    public int Level { get; set; }

    public GodzilaFamilyA()
    {
        Name = "gozila";
        Level = 100;
    }
}