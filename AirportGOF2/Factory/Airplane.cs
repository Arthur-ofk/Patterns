﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF2.Factory
{
    public class Airplane : Aircraft
    {
        public override string GetAircraftType()
        {
            return "Airplane";
        }
    }
}
