using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasThirdRow { get; set; }
        public int CargoHoldCuFeet { get; set; }

        public int Year { get; set; }
        public string VIN { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Motto { get; set; }
        public int YearEstablished { get; set; }

        public void PrintInfo() 
        {
            Console.WriteLine($"This vehicle is a {this.Year} {Make} {Model} SUV. \n" +
               $"It is {HasThirdRow} that it has a third row.\n" +
               $"Its cargo area has {CargoHoldCuFeet} cubic feet of space.\n" +
               $"The {Make} company was established in {YearEstablished}\n" +
               $"and its motto is \"{Motto}\".");
        }
    }
}
