namespace ConsoleApp1.Factory;

public class Giorgi : IProducts
{
    public string Name { get; set; }
    public int Level { get; set; }

    public Giorgi()
    {
        Level = 100;
        Name = "giorgi";
    }
}