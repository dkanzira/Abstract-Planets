using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 17 2017
 * Description: This is the Abstract Planet class
 * version: 0.2 - Added private Instance Variable and the public properties
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
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }
        //CONSTRUCTORS

        //OVERIDE METHOD
    }
}