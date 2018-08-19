using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianWeight
{
    class Program
    {
        /*
        In case you've ever pondered how much you weight on Mars, here's the calculation:
 	    Wm = We* 0.378
 	    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

        Write a command line program which accepts a series of Earth weights from the user  
        and displays each Earth weight as itself, and its Martian equivalent.


        C:\Users> MartianWeight  
        Enter a series of Earth weights (space-separated): 98 235 185
            
        98 lbs.on Earth, is 37 lbs.on Mars.
        235 lbs.on Earth, is 88 lbs.on Mars.
        185 lbs.on Earth, is 69 lbs.on Mars. 
        */
        static void Main(string[] args)
        {

            Console.Write("Enter a series of Earth weights (space-separated): ");
            string earthWeights = Console.ReadLine();
            string[] splitEarthWeights = earthWeights.Split(' ');
            double marsWeight1 = CalculateMarsWeight(splitEarthWeights[0]);
            double marsWeight2 = CalculateMarsWeight(splitEarthWeights[1]);
            double marsWeight3 = CalculateMarsWeight(splitEarthWeights[2]);
            Console.WriteLine(splitEarthWeights[0] + " lbs. on Earth, is " + marsWeight1 +" lbs. on Mars.");
            Console.WriteLine(splitEarthWeights[1] + " lbs. on Earth, is " + marsWeight2 + " lbs. on Mars.");
            Console.WriteLine(splitEarthWeights[2] + " lbs. on Earth, is " + marsWeight3 + " lbs. on Mars.");
            Console.ReadLine();
        }

        static double CalculateMarsWeight(string earthWeight)
        {
            int earthWeightParsed = int.Parse(earthWeight);
            return earthWeightParsed * .378;

        }
    }
}
