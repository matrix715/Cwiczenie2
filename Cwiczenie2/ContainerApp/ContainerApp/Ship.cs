using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class Ship
    {
        public string Name { get; set; }
        public List<Container> Containers { get; set; }
        public double MaxSpeed { get; set; } 
        public double MaxLoadWeight { get; set; } 
        public int MaxContainers { get; set; } 

        public Ship(string name, double maxSpeed, double maxLoadWeight, int maxContainers)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            MaxLoadWeight = maxLoadWeight;
            MaxContainers = maxContainers;
            Containers = new List<Container>();
        }

        public void LoadContainer(Container container)
        {
            if (Containers.Count >= MaxContainers || Containers.Sum(c => c.Weight) + container.Weight > MaxLoadWeight)
            {
                throw new InvalidOperationException("Cannot load more containers. Ship is full.");
            }
            Containers.Add(container);
        }

        public void UnloadContainer(Container container)
        {
            Containers.Remove(container);
        }

        public string GetShipInfo()
        {
            return $"Ship {Name}, Max Speed: {MaxSpeed} knots, Max Load: {MaxLoadWeight} tons, Containers: {Containers.Count}/{MaxContainers}";
        }
    }

}
