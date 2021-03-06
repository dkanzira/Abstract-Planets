﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Student ID#:300914940 
 * Date:July 17 2017
 * Description: This is the Abstract Planet class
 * version: 0.4 - Updted the ToString Method
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
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
                }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

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
         /// <summary>
        /// This is the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //string outputString = "";
            //outputString += "===========================================================\n";
            //outputString += "GiantPlanet :" + this.Name + this.Diameter + "Kilometers" + this.Mass + "Kilograms" + "\n";
            //outputString += "===========================================================\n";
            //outputString += "Facts:" + this.Diameter + "Kilometers" + this.Mass + "Kilograms" + "\n";
            //return outputString;
            return string.Format("Name:{0}\nDiameter:{1}km\nMass:{2}kg\n",this.Name,this.Diameter,this.Mass);
        }
        
    }
}