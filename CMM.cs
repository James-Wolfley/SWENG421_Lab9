namespace SWENG421_Lab9;

public class CMM
{
    private CoffeeIF? cif;
    private ProgramIF? pif;

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
        var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        var input = programName.Trim();
        Type? type = null;

        var candidates = input.EndsWith("Prog", StringComparison.Ordinal)
            ? new[] { input }
            : new[] { input, $"{input}Prog" };

        foreach (var candidate in candidates)
        {
            var fullName = candidate.Contains('.') ? candidate : $"SWENG421_Lab9.{candidate}";
            var resolvedType = assembly.GetType(fullName);
            if (resolvedType != null && typeof(ProgramIF).IsAssignableFrom(resolvedType))
            {
                type = resolvedType;
                break;
            }
        }

        if (type == null || !typeof(ProgramIF).IsAssignableFrom(type))
            throw new ArgumentException($"Unknown program: {programName}");

        pif = (ProgramIF)Activator.CreateInstance(type, this)!;
        Console.WriteLine($"Program set to: {type.Name}");
        return pif;
    }

    public void SetGrindingTime(int secs)
    {
        Console.WriteLine($"Grinding for {secs} seconds");
    }

    public void SetTemperature(int degree)
    {
        Console.WriteLine($"Heating water to {degree}°F");
    }


    public void SetCoffee(CoffeeIF cif)
    {
        this.cif = cif;
        Console.WriteLine($"Coffee set to: {cif.GetDescription()}");
    }

    public void SetLEDNum(int num)
    {
        Console.WriteLine($"LED set to: {num}");
    }


    public void RunProgram()
    {
        if (pif == null)
            throw new InvalidOperationException("Program not set. Call SetProgram(...) before RunProgram().");

        pif.run();
    }


    public double ComputePrice()
    {
        if (cif == null)
            throw new InvalidOperationException("Coffee not set. Call SetCoffee(...) before ComputePrice().");

        return cif.GetPrice();
    }

}
