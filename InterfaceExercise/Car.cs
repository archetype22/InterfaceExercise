using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool IsFuelEfficient { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool HasFourWheels { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
    
}
