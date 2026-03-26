namespace SWENG421_Lab9;

public class RegularProg : ProgramIF
{
    private CMM machine;

    public RegularProg(CMM machine)
    {
        this.machine = machine;
    }

    public void run()
    {
        machine.SetLEDNum(0);
        machine.SetGrindingTime(5);
        machine.SetTemperature(140);
        machine.SetLEDNum(-1);
    }
}
