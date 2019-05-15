using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var argUnit = args?[0] ?? "-tof";

            if (argUnit == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintFeetToMeterList(1, 10);
            }
        }

        static void PrintMeterToFeetList(int first, int last)
        {
            for (int meter = first; meter <= last; meter++)
            {
                double feet = FeetConverter.FromMeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

        static void PrintFeetToMeterList(int first, int last)
        {
            for (var feet = first; feet <= last; feet++)
            {
                double meter = FeetConverter.FromFeetToMeter(feet);
                Console.WriteLine("{0} feet = {1:0.000} meter", feet, meter);
            }
        }
    }
}
