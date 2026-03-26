namespace SWENG421_Lab9;

public class EspressoCoffee : CoffeeIF
{
    private double _basePrice = 5.00;

    public double GetPrice() => _basePrice;
    public string GetDescription() => "Espresso";
}