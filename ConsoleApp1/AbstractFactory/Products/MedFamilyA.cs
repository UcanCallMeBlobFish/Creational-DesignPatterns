namespace ConsoleApp1.AbstractFactory.Products;

public class MedFamilyA : IWarriorMed
{
    public string Name { get; set; }
    public int HelpLevel { get; set; }

    public MedFamilyA()
    {
        Name = "MedA"
            ;
        HelpLevel = 100;
    }
}