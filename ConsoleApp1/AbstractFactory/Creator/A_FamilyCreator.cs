using ConsoleApp1.AbstractFactory.Products;

namespace ConsoleApp1.AbstractFactory.Creator;

public class A_FamilyCreator : AbstractCreator
{
    public override IWarrior CreateWarrior()
    {
        return new GodzilaFamilyA();
    }

    public override IWarriorMed CreateMed()
    {
        return new MedFamilyA();
    }
}