﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Dennis Kanzira
 * Student ID#:300914940    
 * Date:July 18 2017
 * Description: This is the GiantPlanet a sub class of the Abstract Planet class
 * version: 0.5 - Updated the GiantPlanet class
 * 
*/
namespace Abstract_Planets
{
    public class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        //PRIVATE INSTANCE VARIBLES
        private string _type;

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
            _type = type;
        }

        //PUBLIC METHODS
        public bool HasMoons()
        {
            if (MoonCount>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}