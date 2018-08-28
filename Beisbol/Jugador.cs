using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Jugador
    {

        public string Nombre;
        public string Numero;
        
        public Jugador()
        {
            Numero = "2"; 
        }

        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

    }
}
