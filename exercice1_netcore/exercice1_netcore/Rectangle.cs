﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercice1_netcore
{
    public class Rectangle : IShape
    {
        public string Display()
        {
           return "rectangle";
        }
    }
}