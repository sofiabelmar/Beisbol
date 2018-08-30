﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Equipo
    {

        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public Estadio estadio { get; set; }

        public List<Jugador> Jugadores { get; set; }

   
        public Equipo()
        {
            Jugadores = new List<Jugador>();
            Ciudad = "No Registrada";
            Entrenador = "No Registrado";
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
        }
            

    }
}
