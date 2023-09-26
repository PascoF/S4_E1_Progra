using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
     class ArmasCuerpoaCuerpo : Armas,IData 
     {
        public ArmasCuerpoaCuerpo(string nombre, float damage, float speedattack, int precio) : base("Arma", damage, speedattack, precio)
        {
            this.nombre = nombre;
            this.damage = damage;
            this.speedAtackked = speedattack;
            this.precio = precio;
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
            return $"{nombre} - daño: {damage} - velocidad de ataque: {speedAtackked} - precio: {PrecioTotal()}";
        }
    }
}
