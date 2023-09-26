using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
     class ArmasCuerpoaCuerpo : Armas,IData 
     {
        public ArmasCuerpoaCuerpo(string nombrea, float damage, float speedattack, int precioa) : base("Arma", damage, speedattack, precioa)
        {
            this.nombrea = nombrea;
            this.damage = damage;
            this.speedAtackked = speedattack;
            this.precioa = precioa;
        }

        public float DamageForSecond()
        {
            return damage/speedAtackked;
        }
        public float PrecioTotal()
        {
            return precio;
        }


        public string Data()
        {
            return $"{nombrea} - daño: {damage} - velocidad de ataque: {speedAtackked} - precio: {PrecioTotal()}";
        }
    }
}
