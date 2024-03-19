﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF2.Prototype
{
    public class Plane : AircraftPrototype
    {
        public override AircraftPrototype Clone()
        {
            return new Plane();
        }
    }
}
