﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Visitor
{
    public interface IVisitor
    {
        void Visitar(string serie);
    }
}
