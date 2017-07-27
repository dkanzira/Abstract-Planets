using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name:Dennis Kanzira
 * Date:July 26 2017
 * Description: This is the  Program class -(Driver Class)
 * version: 0.2 - Testing the GiantPlanet class
 * 
*/
namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("boom");
            GiantPlanet newPlanet = new GiantPlanet("Earth", 0.0000, 0.0000, "Gas");
            Console.WriteLine(newPlanet.ToString());
            WaitForAnyKey();
        }
       public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }

    }
}
