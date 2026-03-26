namespace SWENG421_Lab9;

public class CMM
{
    private CoffeeIF cif;
    private ProgramIF pif;

    public ProgramIF SetProgram(int num)
    {
        pif = num switch
        {
            0 => new RegularProg(this),
            1 => new MochaProg(this),
            2 => new CappuccinoProg(this),
            _ => throw new ArgumentException($"Unknown program number: {num}")
        };
        Console.WriteLine($"Program set to built-in program {num}");
        return pif;
    }

    public ProgramIF SetProgram(string programName)
    {
        var type = System.Reflection.Assembly.GetExecutingAssembly()
            .GetType($"SWENG421_Lab9.{programName}");
        if (type == null || !typeof(ProgramIF).IsAssignableFrom(type))
            throw new ArgumentException($"Unknown program: {programName}");

        pif = (ProgramIF)Activator.CreateInstance(type, this)!;
        Console.WriteLine($"Program set to: {programName}");
        return pif;
    }

    public ProgramIF setProgram(int num)
    {
        return SetProgram(num);
    }

    public ProgramIF setProgram(string programName)
    {
        return SetProgram(programName);
    }

    public void SetGrindingTime(int secs)
    {
        Console.WriteLine($"Grinding for {secs} seconds");
    }

    public void setGrindingTime(int secs)
    {
        SetGrindingTime(secs);
    }

    public void SetTemperature(int degree)
    {
        Console.WriteLine($"Heating water to {degree}°F");
    }

    public void setTemperature(int degree)
    {
        SetTemperature(degree);
    }

    public void SetCoffee(CoffeeIF cif)
    {
        this.cif = cif;
        Console.WriteLine($"Coffee set to: {cif.GetDescription()}");
    }

    public void setCoffee(CoffeeIF cif)
    {
        SetCoffee(cif);
    }

    public void SetLEDNum(int num)
    {
        Console.WriteLine($"LED set to: {num}");
    }

    public void setLEDNum(int num)
    {
        SetLEDNum(num);
    }

    public void RunProgram()
    {
        pif.run();
    }

    public void runProgram()
    {
        RunProgram();
    }

    public double ComputePrice()
    {
        return cif.GetPrice();
    }

    public double computePrice()
    {
        return ComputePrice();
    }
}
