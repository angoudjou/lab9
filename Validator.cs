﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Validator
    {
        public static bool checkInput( string input)
        { double r;

            return double.TryParse(input, out r);
        }
    }
}
