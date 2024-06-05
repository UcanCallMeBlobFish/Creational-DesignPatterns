namespace ConsoleApp1.AbstractFactory.Products;

public class GodzilaFamilyB : IWarrior
{
    public string Name { get; set; }
    public int Level { get; set; }
    
    public GodzilaFamilyB()
    {
        Name = "gozila";
        Level = 60;
    }
}