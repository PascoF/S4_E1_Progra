using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio2
{
    class ArmasCuerpoaCuerpo : Armas, IData
    {
        public ArmasCuerpoaCuerpo(string name, float damage, float speedAtackked, float precio)
        {
            this.name = name;
            this.damage = damage;
            this.speedAtackked = speedAtackked;
            this.precio = precio;
        }

        public float DamageForSecond()
        {
            return damage / speedAtackked;
        }
        public override float PrecioTotal()
        {
            return precio;
        }


        public string Data()
        {
            return $"{name} - daño: {damage} - velocidad de ataque: {speedAtackked} - precio: {PrecioTotal()}";
        }
    }
}
