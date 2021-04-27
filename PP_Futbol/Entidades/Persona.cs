using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        /// <summary>
        /// Constructor de persona, inicializa todos sus atributos
        /// </summary>
        /// <param name="nombre">Inicializa el nombre</param>
        /// <param name="apellido">Inicializa el apellido</param>
        /// <param name="edad">Inicializa la edad</param>
        /// <param name="dni">Inicializa el dni</param>
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        /// <summary>
        /// Retorna el apellido del jugador
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Retorna el nombre del jugador
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Retorna el dni del jugador
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        /// <summary>
        /// Retorna la edad del jugador
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        /// <summary>
        /// Metodo abstracto para validar en sus clases derivadas
        /// </summary>
        public abstract bool ValidarAptitud();

        /// <summary>
        /// Imprime todos los datos de la persona
        /// </summary>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"DNI: {this.dni}");
            return sb.ToString();
        }
    }
}
