using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Armaduras : Invobjetos
    {
        protected float reducciondano;
        protected float durabilidad;
        protected Armaduras(string nombre, float reducciondano, float durabilidad, int precio) : base("Armadura", precio)
        {
            this.reducciondano = reducciondano;
            this.durabilidad = durabilidad;
        }
    }
}