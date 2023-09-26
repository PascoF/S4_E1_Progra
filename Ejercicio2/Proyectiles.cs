using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Proyectiles : Armas
    {


        public Proyectiles(string nombrea, float damage, float precioa)
        {
            this.nombrea = nombrea;
            this.damage = damage;
            this.precioa = precioa;
        }
        public float Damage()
        {
            return damage;
        }
    }
}
