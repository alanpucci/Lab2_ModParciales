using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private Bar singleton;

        public Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }

        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }

        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }

        public Bar GetBar()
        {
            if (singleton is null)
            {
                singleton = new Bar();
            }
            return singleton;
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            bool repetido = false;
            foreach (Empleado emp in bar.Empleados)
            {
                if(emp == empleado)
                {
                    repetido = true;
                }
            }
            if (!repetido)
            {
                bar.empleados.Add(empleado);
                return true;
            }
            return false;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            if(bar.Empleados.Count > (bar.Gente.Count / 10))
            {
                bar.gente.Add(gente);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Empleado: ");
            foreach (Empleado empleado in this.Empleados)
            {
                sb.AppendLine(empleado.ToString());
            }
            sb.AppendLine("Gente: ");
            foreach (Gente gente in this.Gente)
            {
                sb.AppendLine(gente.ToString());
            }
            return sb.ToString();
        }
    }
}
