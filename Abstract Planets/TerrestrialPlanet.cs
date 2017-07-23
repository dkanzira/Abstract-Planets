using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Dennis Kanzira
 * Date:July 23 2017
 * Description: This is the Abstract Planet class
 * version: 0.2 -Implemented the IHasMoons and IHabitable interfaces
 * 
*/
namespace Abstract_Planets
{
    public class TerrestrialPlanet : Planet,IHasMoons,IHabitable
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
        /// <summary>
        /// This is the main constructor of the Terrestrial Planet
        /// its all the parameters of the Planet base class and oxygen (bool)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass,bool oxygen)
            :base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }
        //PUBLIC METHODS
        public bool HasMoons()
        {
            throw new NotImplementedException();
        }

        public bool Habitable()
        {
            throw new NotImplementedException();
        }
    }
}