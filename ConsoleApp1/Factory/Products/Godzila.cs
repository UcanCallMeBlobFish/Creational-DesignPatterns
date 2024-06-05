namespace ConsoleApp1.Factory;

public class Godzila : IProducts
{
    public Godzila()
    {
        Name = "Godzila";
        Level = 100;
    }
    public  string Name { get; set; }
    public int Level { get; set; }
}