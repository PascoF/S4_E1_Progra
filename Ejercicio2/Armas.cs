using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Armas : Tienda
    {
        public float damage;
        public float speedAtackked;

        protected Armas(string nombre, float damage, float speedattack, int precio) : base("Arma", precio)
        {
            this.damage = damage;
            this.speedAtackked = speedattack;
        }



    }
}
