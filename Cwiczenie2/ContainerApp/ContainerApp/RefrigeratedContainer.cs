using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class RefrigeratedContainer : Container
    {
        public string ProductType { get; set; } 
        public double Temperature { get; set; } 

        public RefrigeratedContainer(string serialNumber) : base(serialNumber)
        {
            Type = "C";
        }

        public override void LoadCargo(double weight)
        {
            base.LoadCargo(weight);
        }

        public override string GetInfo()
        {
            return $"Refrigerated Container {SerialNumber}, Product: {ProductType}, Temperature: {Temperature}°C, Weight: {Weight} kg, Max Load: {MaxLoad} kg";
        }
    }

}
