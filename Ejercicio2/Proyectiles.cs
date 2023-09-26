using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Proyectiles
    {
        public string name;
        public float damage;
        public int precio;

        public Proyectiles(string name, float damage, int precio)
        {
            this.name = name;
            this.damage = damage;
            this.precio = precio;
        }
        public float Damage()
        {
            return damage;
        }

        public float Precio()
        {
            return precio;
        }
    }
}
