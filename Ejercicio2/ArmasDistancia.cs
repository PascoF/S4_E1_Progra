using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio2
{
    class ArmasDistancia : Armas, IDamageSescond, IData
    {
        public Proyectiles proyectiles;
        public ArmasDistancia(string name, float damage, float speedAtackked, float precio, Proyectiles proyectiles)
        {
            this.name = name;
            this.damage = damage;
            this.speedAtackked = speedAtackked;
            this.precio = precio;
            this.proyectiles = proyectiles;
        }

        public float DamageForSecond()
        {
            return damage / speedAtackked;
        }
        public float Damage()
        {
            return proyectiles.Damage() + damage;
        }
        public override float PrecioTotal()
        {
            return precio + proyectiles.precio;
        }

        public string Data()
        {
            return $"{name} - daño : {damage} - velocidad de ataque: {speedAtackked} - precio: {precio} / proyectil : {proyectiles.name} - dañoProyectil : {proyectiles.damage} - precioProyectil : {proyectiles.precio}";
        }
    }
}
