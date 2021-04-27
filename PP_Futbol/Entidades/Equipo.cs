using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        /// <summary>
        /// Constructor privado de equipo, inicializa la lista de jugadores
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Constructor de equipo, inicializa su nombre y la lista de jugadores
        /// </summary>
        /// <param name="nombre"></param>
        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Asigna un valor a director tecnico
        /// </summary>
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        /// <summary>
        /// Retorna el nombre del equipo
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Retorna todos los datos del equipo
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del equipo: {e.Nombre}");
            if (!(e.directorTecnico is null))
            {
                sb.AppendLine($"DT: {e.directorTecnico.Mostrar()}");
            }
            else
            {
                sb.AppendLine("Sin DT asignado");
            }
            sb.AppendLine("Jugadores: ");
            foreach (Jugador jugador in e.jugadores)
            {
                sb.AppendLine($"{jugador.Mostrar()}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Valida si ya esta el jugador incorporado en ese equipo
        /// </summary>
        /// <param name="e">Equipo en cuestion</param>
        /// <param name="j">Jugador a validar</param>
        /// <returns>Retorna true si esta el jugador en el equipo o false si no lo esta</returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach (Jugador jugador in e.jugadores)
            {
                if(j == jugador)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida si no esta el jugador incorporado en ese equipo
        /// </summary>
        /// <param name="e">Equipo en cuestion</param>
        /// <param name="j">Jugador a validar</param>
        /// <returns>Retorna true si no esta el jugador en el equipo o false si lo esta</returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        /// <summary>
        /// Agrega un jugador al equipo siempre y cuando este en condiciones y la cantidad del equipo lo permita
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {
            bool exist = false;
            if(j.ValidarAptitud() && e.jugadores.Count < cantidadMaximaJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if(jugador == j)
                    {
                        exist = true;
                    }
                }
                if (!exist)
                {
                    e.jugadores.Add(j);
                }
            }
            return e;
        }

        /// <summary>
        /// Valida que exista un director tecnico, que la cantidad de jugadores sea la adecuada y que haya por lo menos un jugador de cada posicion (de arquero solo tiene que haber 1)
        /// </summary>
        /// <param name="e">Equipo en cuestion</param>
        public static bool ValidarEquipo(Equipo e)
        {
            int contadorArqueros = 0;
            bool hayDelantero = false;
            bool hayDefensor = false;
            bool hayCentral = false;
            if(!(e.directorTecnico is null) && e.jugadores.Count == cantidadMaximaJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    switch (jugador.Posicion)
                    {
                        case Posicion.Arquero:
                            contadorArqueros++;
                            break;
                        case Posicion.Defensor:
                            hayDefensor = true;
                            break;
                        case Posicion.Central:
                            hayCentral = true;
                            break;
                        case Posicion.Delantero:
                            hayDelantero = true;
                            break;
                    }
                }
                if(contadorArqueros == 1 && hayCentral && hayDefensor && hayDelantero)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
