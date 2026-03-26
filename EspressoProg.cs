namespace SWENG421_Lab9;

public class EspressoProg : ProgramIF
{
    private CMM machine;

    public EspressoProg(CMM machine)
    {
        this.machine = machine;
    }

    public void run()
    {
        machine.SetLEDNum(3);
        machine.SetGrindingTime(5);
        machine.SetTemperature(200);
        machine.SetLEDNum(-1);
    }
}
