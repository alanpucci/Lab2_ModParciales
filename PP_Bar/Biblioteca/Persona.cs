using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        protected Persona(string nombre, short edad)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public short Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Edad: {this.Edad}");
            return sb.ToString();
        }

        public static explicit operator string(Persona persona)
        {
            return persona.Nombre;
        }

        public abstract bool Validar();
    }
}
