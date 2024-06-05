namespace ConsoleApp1.AbstractFactory.Products;

public class MedFamilyB : IWarriorMed
{
    public string Name { get; set; }
    public int HelpLevel { get; set; }
    
    public MedFamilyB()
    {
        Name = "MedB";
        HelpLevel = 0;
    }
}