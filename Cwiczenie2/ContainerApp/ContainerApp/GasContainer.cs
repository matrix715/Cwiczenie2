using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class GasContainer : Container, IHazardNotifier
    {
        public double Pressure { get; set; } 

        public GasContainer(string serialNumber) : base(serialNumber)
        {
            Type = "G";
        }

        public override void LoadCargo(double weight)
        {
            if (weight > MaxLoad)
                throw new InvalidOperationException("Cargo exceeds container capacity.");
            base.LoadCargo(weight);
        }

        public void SendHazardNotification(string message)
        {
            Console.WriteLine($"Gas container {SerialNumber}: {message}");
        }

        public override string GetInfo()
        {
            return $"Gas Container {SerialNumber}, Weight: {Weight} kg, Pressure: {Pressure} atm, Max Load: {MaxLoad} kg";
        }
    }

}
