using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    abstract class Tienda
    {
        protected string nombre;
        protected int precio;
        protected Tienda(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public string ObtenernmbrObjeto()
        {
            return nombre;
        }


        public abstract float precioa { get; set; }
        public abstract string nombrea { get; set; }

        public abstract float PrecioTotal();


    }

   
  
}
