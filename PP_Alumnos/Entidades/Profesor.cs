using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        private DateTime fechaIngreso;

        /// <summary>
        /// Constructor de profesor, inicializa los atributos de persona
        /// </summary>
        /// <param name="nombre">Inicializa nombre</param>
        /// <param name="apellido">Inicializa apellido</param>
        /// <param name="documento">Inicializa documento</param>
        public Profesor(string nombre, string apellido, string documento):base(nombre,apellido,documento)
        {
            
        }

        /// <summary>
        /// Constructor de profesor, inicializa los atributos de persona y la fecha de ingreso
        /// </summary>
        /// <param name="nombre">Inicializa nombre</param>
        /// <param name="apellido">Inicializa apellido</param>
        /// <param name="documento">Inicializa documento</param>
        /// <param name="fechaIngreso">Inicializa fecha de ingreso</param>
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso):this(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        /// <summary>
        /// Retorna la diferencia en dias entre la fecha actual y la fecha de ingreso
        /// </summary>
        public int Antiguedad
        {
            get
            {
                return (int)(new DateTime() - this.fechaIngreso).TotalDays;
            }
        }

        /// <summary>
        /// Valida que el documento tenga 9 caracteres
        /// </summary>
        /// <param name="doc">Documento a validar en formato string</param>
        protected override bool ValidarDocumentacion(string doc)
        {
            return doc.Length == 8;
        }

        /// <summary>
        /// Retorna los datos de persona y la fecha de ingreso del profesor
        /// </summary>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine($"Fecha ingreso: {this.fechaIngreso}");
            return sb.ToString();
        }
    }
}
