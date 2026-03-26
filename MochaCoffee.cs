namespace SWENG421_Lab9;

public class MochaCoffee : CoffeeIF
{
    private double _basePrice = 4.00;

    public double GetPrice() => _basePrice;
    public string GetDescription() => "Mocha";
}