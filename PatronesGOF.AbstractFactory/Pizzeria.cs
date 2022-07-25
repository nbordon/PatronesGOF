﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.AbstractFactory
{
    public abstract class Pizzeria
    {
        public abstract Pizza CrearPizza();
        public abstract Empanada CrearEmpanada();
    }
}
