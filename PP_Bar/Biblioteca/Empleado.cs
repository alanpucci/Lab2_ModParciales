using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado:Persona
    {
        private int dni;

        public Empleado(string nombre, short edad):base(nombre, edad)
        {
            this.dni = -1;
        }

        public Empleado(string nombre, short edad, int dni) : this(nombre, edad)
        {
            this.dni = dni;
        }

        public override bool Validar()
        {
            return this.Edad > 21 && this.Nombre.Length > 1;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return (e1.Nombre == e2.Nombre && e1.Edad == e2.Edad);
        }

        protected override string Mostrar()
        {
            if (this.Validar())
            {
                return base.Mostrar();
            }
            return "No es un empleado";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
