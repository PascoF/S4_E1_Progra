using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Invobjetos
    {
        protected string nombre;
        protected int precio;
        protected Invobjetos(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public string ObtenernmbrObjeto()
        {
            return nombre;
        }
    }
}
