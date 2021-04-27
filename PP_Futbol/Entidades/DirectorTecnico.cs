using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        private int añosExperiencia;

        /// <summary>
        /// Constructor de director tecnico, inicializa todos sus atributos incluidos los de persona
        /// </summary>
        /// <param name="nombre">Inicializa el nombre</param>
        /// <param name="apellido">Inicializa el apellido</param>
        /// <param name="edad">Inicializa la edad</param>
        /// <param name="dni">Inicializa el dni</param>
        /// <param name="añosExperiencia">Inicializa los años de experiencia</param>
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        /// <summary>
        /// Asigna o retorna los años de experiencia
        /// </summary>
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }

        /// <summary>
        /// Valida que el director tecnico sea menor de 65 años y tenga al menos 2 años de experiencia
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            return this.Edad < 65 && this.añosExperiencia >= 2;
        }

        /// <summary>
        /// Imprime los datos del director tecnico
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Años de experiencia: {this.añosExperiencia}");
            return sb.ToString();
        }
    }
}
