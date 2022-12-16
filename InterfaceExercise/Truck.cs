using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasBed { get; set; }
        public bool HasTailgate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool HasFourWheels { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
