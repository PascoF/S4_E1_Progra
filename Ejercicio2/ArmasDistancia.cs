﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ArmasDistancia : Armas,IDamageSescond,IData
    {
        public Proyectiles proyectiles;
        public ArmasDistancia(string name, float damage, float speedattack, int precio,Proyectiles proyectiles) : base("Arco", damage, speedattack, precio)
        {
            this.nombre = name;
            this.damage = damage;
            this.speedAtackked = speedattack;
            this.precio = precio;
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
        public float PrecioTotal()
        {
            return precio+proyectiles.Precio();
        }

        public string Data()
        {
            return $"{nombre} - daño : {damage} - velocidad de ataque: {speedAtackked} - precio: {precio} / proyectil : {proyectiles.name} - dañoProyectil : {proyectiles.damage} - precioProyectil : {proyectiles.precio}";
        }
    }
}
