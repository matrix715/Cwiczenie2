using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        public bool IsHazardous { get; set; } 
        public double Pressure { get; set; }

        public LiquidContainer(string serialNumber) : base(serialNumber)
        {
            Type = "L";
        }

        public override void LoadCargo(double weight)
        {
            double maxAllowed = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
            if (weight > maxAllowed)
                throw new InvalidOperationException("Cannot load hazardous materials beyond 50% capacity.");
            base.LoadCargo(weight);
        }

        public void SendHazardNotification(string message)
        {
            Console.WriteLine($"Hazardous container {SerialNumber}: {message}");
        }

        public override string GetInfo()
        {
            return $"Liquid Container {SerialNumber}, Weight: {Weight} kg, Max Load: {MaxLoad} kg";
        }
    }

}
