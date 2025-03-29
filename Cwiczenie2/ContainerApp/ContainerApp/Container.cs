using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    
        public abstract class Container
        {
            public string SerialNumber { get; private set; }
            public double Weight { get; set; } 
            public double Depth { get; set; }
            public double MaxLoad { get; set; } 
            public double EmptyWeight { get; set; } 
            public string Type { get; set; } 

            protected Container(string serialNumber)
            {
                this.SerialNumber = serialNumber;
            }

            public virtual void LoadCargo(double weight)
            {
                if (weight > MaxLoad)
                    throw new OverfillException("Cargo exceeds container capacity.");
                Weight += weight;
            }

            public void UnloadCargo()
            {
                Weight = 0;
            }

            public abstract string GetInfo();
        }

    
}
