using ConsoleApp1.AbstractFactory.Products;

namespace ConsoleApp1.AbstractFactory.Creator;

public class B_FamilyCreator : AbstractCreator
{
    public override IWarrior CreateWarrior()
    {
        return new GodzilaFamilyB();
    }

    public override IWarriorMed CreateMed()
    {
        return new MedFamilyB();
    }
}