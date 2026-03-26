namespace SWENG421_Lab9;

public class Cream : CondimentIF
{
    private double _basePrice = 0.25;

    public Cream(CoffeeIF coffee) : base(coffee) { }

    public override double GetPrice() => _coffee.GetPrice() + _basePrice;
    public override string GetDescription() => _coffee.GetDescription() + " + Cream";
}
