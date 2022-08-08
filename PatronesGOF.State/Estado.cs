using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.State
{
    public abstract class Estado
    {
        // Métodos
        public abstract void ControlarEstado(Switch sw);
        public abstract string Describir();
    }
}
