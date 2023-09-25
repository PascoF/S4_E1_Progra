using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    abstract class Armas : Tienda
    {
        public override string name { get; set; }
        public float damage;
        public float speedAtackked;
        public override float precio { get; set; }

        public override float PrecioTotal()
        {
            return 0;
        }
    }
}
