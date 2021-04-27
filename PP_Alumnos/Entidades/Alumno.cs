using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno:Persona
    {
        private short anio;
        private Divisiones division;

        /// <summary>
        /// Constructor de alumno, inicializa los atributos de persona, el año y la division
        /// </summary>
        /// <param name="nombre">Inicializa nombree</param>
        /// <param name="apellido">Inicializa el apellido</param>
        /// <param name="documento">Inicializa el documento</param>
        /// <param name="anio">Inicializa el año</param>
        /// <param name="division">Inicializa la division</param>
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            :base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        /// <summary>
        /// Retorna el año y la division
        /// </summary>
        public string AnioDivision
        {
            get
            {
                return $"{this.anio}°{this.division}";
            }
        }

        /// <summary>
        /// Valida que el documento tenga - en la posicion 2 y 7 y el resto sean numeros
        /// </summary>
        /// <param name="doc">Documento a validar</param>
        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            if(doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                for (int i = 0; i < doc.Length; i++)
                {
                    if ((i == 2 || i == 7) || int.TryParse(doc[i].ToString(), out _))
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Retorna los datos del alumno junto a su division
        /// </summary>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine($"Division: {this.AnioDivision}");
            return sb.ToString();
        }
    }
}
