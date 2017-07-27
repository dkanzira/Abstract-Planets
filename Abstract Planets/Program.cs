using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name:Dennis Kanzira
 * Student ID#:300914940 
 * Date:July 26 2017
 * Description: This is the  Program class -(Driver Class)
 * version: 0.2 - Testing the TerrestrialPlanet class
 * 
*/
namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************");
            GiantPlanet newPlanet = new GiantPlanet("Earth", 2141.1, 32411.1, "Gas");
            Console.WriteLine(newPlanet.ToString());
            Console.WriteLine("**********************************************************************");
            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            TerrestrialPlanet terrestrialP = new TerrestrialPlanet("Jupitar", 482374.123, 24525.112, true);
            Console.WriteLine(terrestrialP.ToString());
            Console.WriteLine("**********************************************************************");
            WaitForAnyKey();
        }
       public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }

    }
}
