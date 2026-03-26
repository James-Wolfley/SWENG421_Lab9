namespace SWENG421_Lab9;

public abstract class CondimentIF : CoffeeIF
{
    protected CoffeeIF _coffee;

    protected CondimentIF(CoffeeIF coffee)
    {
        _coffee = coffee;
    }

    public abstract double GetPrice();
    public abstract string GetDescription();
}