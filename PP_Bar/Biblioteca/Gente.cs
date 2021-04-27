using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gente:Persona
    {
        public Gente(short edad):base("",edad)
        {
        }

        public Gente(string nombre, short edad) : base(nombre, edad)
        {

        }

        public override bool Validar()
        {
            return this.Edad > 18;
        }

        protected override string Mostrar()
        {
            if (this.Validar())
            {
                return base.Mostrar();
            }
            return "No es GENTE";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
