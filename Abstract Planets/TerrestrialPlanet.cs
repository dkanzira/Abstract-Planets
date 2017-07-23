using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Dennis Kanzira
 * Date:July 23 2017
 * Description: This is the Abstract Planet class
 * version: 0.1 - Create the TerrestrialPlanet, a subclass of Planets
 * 
*/
namespace Abstract_Planets
{
    public class TerrestrialPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen
        {
            get
            {
                return this._oxygen;
            }
            set
            {
                this._oxygen = value;
            }
         }

        //CONSTRUCTORS ---------------------------------------------
        public TerrestrialPlanet(string name, double diameter, double mass,bool oxygen)
            :base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }
        //PUBLIC METHODS

    }
}