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
        private string documento;
        private string nombre;

        /// <summary>
        /// Constructor de persona, inicializa todos sus atributos
        /// </summary>
        /// <param name="nombre">Inicializa el nombre</param>
        /// <param name="apellido">Inicializa el apellido</param>
        /// <param name="documento">Inicializa el documento</param>
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            if (this.ValidarDocumentacion(documento))
            {
                this.documento = documento;
            }
        }

        /// <summary>
        /// Retorna el apellido de la persona
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Retorna el documento de la persona
        /// </summary>
        public string Documento
        {
            set
            {
                if (this.ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
            get
            {
                return this.documento;
            }
        }

        /// <summary>
        /// Retorna el nombre de la persona
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Metodo abstracto, recibe un documento como string para luego validarlo en sus derivadas
        /// </summary>
        /// <param name="doc">String a validar</param>
        protected abstract bool ValidarDocumentacion(string doc);

        /// <summary>
        /// Retorna todos los datos de la persona
        /// </summary>
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"DNI: {this.documento}");
            return sb.ToString();
        }
    }
}
