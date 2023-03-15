using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Year { get; set; }
        public string VIN { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        //public void PrintInfo();
    }
}
