namespace ConsoleApp1.Factory;

public class ConcreteCreator_Giorgi : ICreator_Monster
{
    public override IProducts CreateConcreteProduct()
    {
        return new Giorgi();
    }
}