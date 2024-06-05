namespace ConsoleApp1.Singleton;

public class CarSingleton
{
    private static CarSingleton Unique;
    private CarSingleton() { }

    public static CarSingleton CreateCarObject()
    {
        if (Unique is null)
        {
            Unique = new CarSingleton();
            return Unique;
        }

        return Unique;
    }
    
}