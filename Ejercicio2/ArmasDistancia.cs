using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ArmasDistancia : Armas,IDamageSescond,IData
    {
        public Proyectiles proyectiles;
        public ArmasDistancia(string nombrea, float damage, float speedAtackked, float precioa,Proyectiles proyectiles)
        {
            this.nombrea = nombrea;
            this.damage = damage;
            this.speedAtackked = speedAtackked;
            this.precioa = precioa;
            this.proyectiles= proyectiles;
        }

        public float DamageForSecond()
        {
            return damage/speedAtackked;
        }
        public float Damage()
        {
            return proyectiles.Damage() + damage;
        }
        public override float PrecioTotal()
        {
            return precio+proyectiles.precioa;
        }

        public string Data()
        {
            return $"{nombrea} - daño : {damage} - velocidad de ataque: {speedAtackked} - precio: {precio} / proyectil : {proyectiles.nombrea} - dañoProyectil : {proyectiles.damage} - precioProyectil : {proyectiles.precio}";
        }
    }
}
