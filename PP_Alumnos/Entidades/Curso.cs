using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        /// <summary>
        /// Constructor privado, inicializa la lista de alumnos
        /// </summary>
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor de curso, inicializa sus atributos
        /// </summary>
        /// <param name="anio">Inicializa el año</param>
        /// <param name="division">Inicializa la division</param>
        /// <param name="profesor">Inicializa el profesor</param>
        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
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
        /// Conversion explicita a string del curso
        /// </summary>
        /// <param name="c">Curso a convertir</param>
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Division: {c.AnioDivision}");
            sb.AppendLine($"Profesor: {c.profesor.ExponerDatos()}");
            foreach (Alumno alumno in c.alumnos)
            {
                sb.AppendLine(alumno.ExponerDatos());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Valida que el alumno sea del mismo año y division que el curso
        /// </summary>
        /// <param name="c">Curso a validar</param>
        /// <param name="a">Alumno a validar</param>
        public static bool operator ==(Curso c, Alumno a)
        {
            return a.AnioDivision == c.AnioDivision;
        }

        /// <summary>
        /// Valida que el alumno y el curso sean de distinto año y division
        /// </summary>
        /// <param name="c">Curso a validar</param>
        /// <param name="a">Alumno a validar</param>
        /// <returns></returns>
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        /// <summary>
        /// Agrega un alumno a un curso siempre y cuando sean del mismo año y division
        /// </summary>
        /// <param name="c">Curso en cuestion</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns></returns>
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
    }
}
