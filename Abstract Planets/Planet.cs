using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 17 2017
 * Description: This is the Abstract Planet class
 * version: 0.4 - Updted Public methods and Public Properties
 * 
*/
namespace Abstract_Planets
{
    /// <summary>
    /// This the public Abstract class For Planet
    /// </summary>
    public abstract class Planet
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES

        public double Diameter
        {
            get
            {
                return this._diameter;
            }
                
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount { get; set; }
        public string Name
        {
            get
            {
                return this._name;
            }
                
        }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }

        //CONSTRUCTORS
        /// <summary>
        /// This is the main Constructor of the Planet Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name,double diameter,double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        //OVERIDE METHOD
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0},{1},{2}",Name,Mass,Diameter);
        }
    }
}