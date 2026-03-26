namespace SWENG421_Lab9;

public class RegularCoffee : CoffeeIF
{
    private double _basePrice = 2.00;

    public double GetPrice() => _basePrice;
    public string GetDescription() => "Regular";
}