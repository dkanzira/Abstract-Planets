using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Dennis Kanzira
 * Date:July 23 2017
 * Description: This is the Abstract Planet class
 * version: 0.1 - Created The IHasMoons, an interface class
 *
*/
namespace Abstract_Planets
{
    public interface IHasMoons
    {
        //PUBLIC PROPERTY
        //int Moons { get; set; }

        //PUBLIC METHODS
        bool HasMoons();
        
    }
}