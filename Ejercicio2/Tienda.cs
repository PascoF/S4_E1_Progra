using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    abstract class Tienda
    {
        public abstract float precio { get; set; }
        public abstract string name { get; set; }

        public abstract float PrecioTotal();


    }
}
