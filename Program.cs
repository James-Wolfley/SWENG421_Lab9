namespace SWENG421_Lab9;

class Program
{
    static void Main(string[] args)
    {
        var machine = new CMM();

        Console.WriteLine("Drink 1: Mocha");
        machine.SetProgram(1);

        CoffeeIF mocha = new MochaCoffee();
        mocha = new Cream(mocha);
        mocha = new Vanilla(mocha);

        machine.SetCoffee(mocha);
        machine.RunProgram();

        double price1 = machine.ComputePrice();
        Console.WriteLine($"Price: ${price1:F2}");

        Console.WriteLine();

        Console.WriteLine("Drink 2: Espresso");
        machine.SetProgram("EspressoProg");

        CoffeeIF espresso = new EspressoCoffee();
        espresso = new Cream(espresso);
        espresso = new Vanilla(espresso);
        espresso = new Chocolate(espresso);
        espresso = new Chocolate(espresso);

        machine.SetCoffee(espresso);
        machine.RunProgram();

        double price2 = machine.ComputePrice();
        Console.WriteLine($"Price: ${price2:F2}");
    }
}
