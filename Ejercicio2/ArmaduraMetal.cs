using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ArmaduraMetal : Armaduras
    {
        public ArmaduraMetal(string nombre, float reducciondano, float durabilidad, int precio) : base("ArmaduraMetal", reducciondano, durabilidad, precio)
        {
            this.nombre = nombre;
        }
        public float ReduccionDano()
        {
            return reducciondano;
        }
        public string Data()
        {
            return $"{nombre} / La reduccion de daño de la armadura es... {reducciondano} / su durabilidad es {durabilidad} / Con todo esto, el precio de la armadura es... {precio}";
        }
    }
}
