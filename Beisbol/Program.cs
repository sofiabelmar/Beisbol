using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Equipo> equipos = new List<Equipo>();

            Equipo equipo1 = new Equipo();
            equipo1.Nombre = "Black Team";
            equipo1.Ciudad = "Saxony";
            equipo1.Entrenador = "Gunter";

            equipo1.estadio = new Estadio();
            equipo1.estadio.Nombre = "Arena";
            equipo1.estadio.Direccion = "Atras del Palacio Municipal";
            equipo1.estadio.Capacidad= 2000;



            equipo1.Jugadores.Add(new Jugador("Adrian"));
            equipo1.Jugadores.Add(new Jugador("Rodrigo"));
            equipo1.Jugadores.Add(new Jugador("Alan"));
            equipo1.Jugadores.Add(new Jugador("Reynoldo"));
            equipo1.Jugadores.Add(new Jugador("Arturo"));
            equipos.Add(equipo1);

            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Red Team";
            equipo2.Ciudad = "Rusviet";
            equipo2.Entrenador = "Olga";

          

            equipo2.Jugadores.Add(new Jugador("Omar"));        //AGRGAR DATO A LISTA DE JUGADORES
            equipo2.Jugadores.Add(new Jugador("José"));
            equipo2.Jugadores.Add(new Jugador("Oswald"));
            equipo2.Jugadores.Add(new Jugador("Jorge"));
            equipo2.Jugadores.Add(new Jugador("Otelo"));
            equipos.Add(equipo2);                              //AGREGAR EL DATO A LA LISTA DE MATERIAS

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Nombre: " + equipo.Nombre);
                Console.WriteLine("Ciudad: " + equipo.Ciudad);
                Console.WriteLine("Entrenador: " + equipo.Entrenador);

                if(equipo.estadio != null) {
                    Console.WriteLine("-----------");
                    Console.WriteLine("Estadio: " + equipo.estadio.Nombre);
                    Console.WriteLine("Direccion: " + equipo.estadio.Direccion);
                    Console.WriteLine("Capacidad: " + equipo.estadio.Capacidad);
                    Console.WriteLine("-----------");
                }
                else { Console.WriteLine("---Sin Estadio---"); }

                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("Jugador: " + jugador.Nombre);
                }
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
