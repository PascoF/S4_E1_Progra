using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Proyectiles : Armas
    {


        public Proyectiles(string name, float damage, float precio)
        {
            this.name = name;
            this.damage = damage;
            this.precio = precio;
        }
        public float Damage()
        {
            return damage;
        }
    }
}
