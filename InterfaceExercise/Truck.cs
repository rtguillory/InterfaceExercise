using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double BedLength { get; set; }
        public bool ExtendedCab { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Motto { get; set; }
        public int YearEstablished { get; set; }

        public string PrintInfo() 
        { 
            return ($"\nThis vehicle is a {this.Year} {Make} {Model} truck. \n" +
               $"It is {ExtendedCab} that it has an extended cab.\n" +
               $"Its truck bed is {BedLength} feet long.\n" +
               $"The {Make} company was established in {YearEstablished}\n" +
               $"and its motto is \"{Motto}\".");
        }
    }
}
