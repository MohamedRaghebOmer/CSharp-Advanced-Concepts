using System;

public class Thermostat
{
    public event EventHandler<ThermostatEventArgs> TemperatureChanged;
    private int _oldTemperature;
    private int _currentTemperature;

    public string Name { get; set; }

    public class ThermostatEventArgs : EventArgs
    {
        public int OldTemperature { get; }
        public int NewTemperature { get; }
        public int Difference { get; }

        public ThermostatEventArgs(int oldTemperature, int newTemperature)
        {
            this.OldTemperature = oldTemperature;
            this.NewTemperature = newTemperature;
            this.Difference = newTemperature - oldTemperature;
        }
    }

    public void RaiseTemperatureChanged(ThermostatEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }

    public void RaiseTemperatureChanged(int oldTemperature, int newTemperature)
    {
        RaiseTemperatureChanged(new ThermostatEventArgs(oldTemperature, newTemperature));
    }

    public void SetTemperature(int newTemperature)
    {
        if (newTemperature != this._currentTemperature)
        {
            _oldTemperature = _currentTemperature;
            _currentTemperature = newTemperature;
            RaiseTemperatureChanged(_oldTemperature, _currentTemperature);
        }
    }
}

public class Display
{
    public void Subscribe(Thermostat thermostat)
    {
        thermostat.TemperatureChanged += Thermostat_TemperatureChanged;
    }

    private void Thermostat_TemperatureChanged(object sender, Thermostat.ThermostatEventArgs e)
    {
        Thermostat thermostat = sender as Thermostat;

        Console.WriteLine($"Temperature changed in {thermostat.Name}");
        Console.WriteLine($"Old temperature is {e.OldTemperature}°C");
        Console.WriteLine($"New temperature is {e.NewTemperature}°C");
        Console.WriteLine($"Difference is {e.Difference}°C");
        Console.WriteLine("\n____________________________________\n");
    }
}

internal static class Program
{
    static void Main(string[] args)
    {
        Thermostat thermostat1 = new Thermostat();
        thermostat1.Name = "Thermo 1";

        Thermostat thermostat2 = new Thermostat();
        thermostat2.Name = "Thermo 2";

        Display display = new Display();

        display.Subscribe(thermostat1);
        display.Subscribe(thermostat2);

        thermostat1.SetTemperature(20);
        thermostat2.SetTemperature(20);
    }
}

