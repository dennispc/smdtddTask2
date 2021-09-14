using System;
using DPcode.Core.Models;

namespace DPcode.Domain
{
    public class WheatherChecker : IWheatherChecker
    {
        /*
        Exercise 2
        This exercise consist of three steps

        First you should implement a function using tdd that can be used to decde whether or not a cloudburst is present.
        The data representing rain is an array of doubles.
        Each entry representing the amount of rain in milimetres in 5 minutes.
        Find the definition of cloudburst.

        **Rainfall rate equal to or greater than 100 millimetres (3.9 in) per hour is a cloudburst.**
        Them implement a logical function

        int ContainsCloudBurst(double[])

        the function must return -1 in case there are no cloudbursts. 
        Otherwise it will return the first index of the first occurence of a period with couldburst.

        The second step of the exercise us to do the same for heavy rain.

        **Heavy rain: Greater than 4 mm per hour, but less than 8 mm per hour. Very heavy rain: Greater than 8 mm per hour. Slight shower: Less than 2 mm per hour. Moderate shower: Greater than 2 mm, but less than 10 mm per hour.*
        The two functions are similar.
        Remove that by refactoring and used tests to en sure that the functionality is still ok

        The final step: 
        Refactor to remove code smells.
        */


        public int ContainsCloudBurst(double[] arrayOfRain)
        {
            return CompareArrayToLowerLimit(Rain.cloudBurstLowLimit,arrayOfRain);
        }

        public int ContainsHeavyRain(double[] arrayOfRain)
        {
            return CompareArrayToLowerLimit(Rain.heavyRainLowerLimit,arrayOfRain);
        }

        public int ContainsVeryHeavyRain(double[] arrayOfRain)
        {
            return CompareArrayToLowerLimit(Rain.veryHeavyRainLowerLimit,arrayOfRain);
        }

        private int CompareArrayToLowerLimit(double lowerLimit, double[] arrayOfRain)
        {
            for (int i = 0; i < arrayOfRain.Length; i++)
                if (FiveMinsToHour(arrayOfRain[i]) > lowerLimit) return i;
            return -1;
        }

        private double FiveMinsToHour(double fiveMins)
        {
            return 12 * fiveMins;
        }
    }
}
