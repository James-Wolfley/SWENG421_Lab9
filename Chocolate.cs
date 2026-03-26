namespace SWENG421_Lab9;

public class Chocolate : CondimentIF
{
    private double _basePrice = 1.00;

    public Chocolate(CoffeeIF coffee) : base(coffee) { }

    public override double GetPrice() => _coffee.GetPrice() + _basePrice;
    public override string GetDescription() => _coffee.GetDescription() + " + Chocolate";
}