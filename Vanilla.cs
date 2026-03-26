namespace SWENG421_Lab9;

public class Vanilla : CondimentIF
{
    private double _basePrice = 0.50;

    public Vanilla(CoffeeIF coffee) : base(coffee) { }

    public override double GetPrice() => _coffee.GetPrice() + _basePrice;
    public override string GetDescription() => _coffee.GetDescription() + " + Vanilla";
}