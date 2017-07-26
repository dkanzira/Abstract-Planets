using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Dennis Kanzira
 * Date:July 18 2017
 * Description: This is the Abstract Planet class
 * version: 0.4 - Implemented the IHasMoons and IHasRings interfaces
 * 
*/
namespace Abstract_Planets
{
    public class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        //PRIVATE INSTANCE VARIBLES
        private string _type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        //CONSTRUCTORS --------------------------------------------
        /// <summary>
        /// This is the main Constructor of the GiantPlanet class
        /// It takes three parameters - name(string) - diameter(double) - mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public GiantPlanet(string name,double diameter,double mass, string type)
            :base(name,diameter,mass)
        {
            this._type = type;
        }

        public bool HasMoons()
        {
            if (MoonCount>0)
            {
                Console.WriteLine("");
            }
            return true;
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                Console.WriteLine("");
            }
            return true;
        }
    }
}