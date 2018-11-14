using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbolito
{
    class Nodo
    {
        // Es el atributo de nombre 
        public string Name; 
        // Un Arrgelo nodo
        public Nodo[] Arreglo; 
        // constructor para el nombre de nodo que se va a crear
        public Nodo(string Nombre)
        {
            Name = Nombre;
        }
    }
}
