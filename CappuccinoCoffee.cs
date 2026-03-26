namespace SWENG421_Lab9;

public class CappuccinoCoffee : CoffeeIF
{
    private double _basePrice = 3.00;

    public double GetPrice() => _basePrice;
    public string GetDescription() => "Cappuccino";
}