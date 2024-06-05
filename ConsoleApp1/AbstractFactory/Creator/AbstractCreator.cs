using ConsoleApp1.AbstractFactory.Products;

namespace ConsoleApp1.AbstractFactory.Creator;

public abstract class AbstractCreator
{
    public abstract IWarrior CreateWarrior();
    public abstract IWarriorMed CreateMed();
}