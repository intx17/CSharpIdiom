using System;
namespace DistanceConverter
{
    public static class FeetConverter
    {
        public static readonly double feetRatio = 0.3048;

        public static double FromMeterToFeet(double meter)
        {
            return meter / feetRatio;
        }

        public static double FromFeetToMeter(double feet)
        {
            return feet * feetRatio;
        }
    }
}
