using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        /// <summary>
        /// Constructor de jugador, inicializa todos sus atributos
        /// </summary>
        /// <param name="nombre">Inicializa el nombre</param>
        /// <param name="apellido">Inicializa el apellido</param>
        /// <param name="edad">Inicializa la edad</param>
        /// <param name="dni">Inicializa el dni</param>
        /// <param name="peso">Inicializa el peso</param>
        /// <param name="altura">Inicializa la altura</param>
        /// <param name="posicion">Inicializa la posicion</param>
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            :base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        /// <summary>
        /// Retorna la altura del jugador
        /// </summary>
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        /// <summary>
        /// Retorna el peso del jugador
        /// </summary>
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }


        /// <summary>
        /// Retorna la posicion del jugador
        /// </summary>
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        /// <summary>
        /// Valida que el IMC del jugador este en un rango de 18.5 a 25
        /// </summary>
        /// <returns></returns>
        public bool ValidarEstadoFisico()
        {
            double IMC = this.peso / Math.Pow(this.altura,2);
            return IMC > 18.5f && IMC <= 25;
        }

        /// <summary>
        /// Valida que el jugador sea menor de 40 años y que este en estado fisico
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            return this.Edad < 40 && this.ValidarEstadoFisico();
        }

        /// <summary>
        /// Muestra todos los datos del jugador
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Altura: {this.Altura}");
            sb.AppendLine($"Peso: {this.Peso}");
            sb.AppendLine($"Posicion: {this.Posicion.ToString()}");
            return sb.ToString();
        }
    }
}
