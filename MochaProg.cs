namespace SWENG421_Lab9;

public class MochaProg : ProgramIF
{
    private CMM machine;

    public MochaProg(CMM machine)
    {
        this.machine = machine;
    }

    public void run()
    {
        machine.SetLEDNum(1);
        machine.SetGrindingTime(8);
        machine.SetTemperature(150);
        machine.SetLEDNum(-1);
    }
}
