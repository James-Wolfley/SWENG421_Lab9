namespace SWENG421_Lab9;

public class CappuccinoProg : ProgramIF
{
    private CMM machine;

    public CappuccinoProg(CMM machine)
    {
        this.machine = machine;
    }

    public void run()
    {
        machine.SetLEDNum(2);
        machine.SetGrindingTime(6);
        machine.SetTemperature(160);
        machine.SetLEDNum(-1);
    }
}
