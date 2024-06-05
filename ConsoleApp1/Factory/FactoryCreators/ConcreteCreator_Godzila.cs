namespace ConsoleApp1.Factory;

public class ConcreteCreator_Godzila : ICreator_Monster
{
    public override IProducts CreateConcreteProduct()
    {
        return new Godzila();
    }
}