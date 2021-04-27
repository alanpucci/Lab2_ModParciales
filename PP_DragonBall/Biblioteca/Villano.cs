using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Villano:Personaje
    {
        private bool maximoPoder;
        private EOrigen origen;

        public Villano(string nombre, int nivelPoder, List<EHabilidades> ataques, EOrigen origen):base(nombre,nivelPoder,ataques)
        {
            this.origen = origen;
        }

        protected override string Descripcion
        {
            get
            {
                return "Soy Malísimo. Diabólico. Así como los profes de labo de la noche";
            }
        }

        public override string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.InfoPersonaje());
            sb.AppendLine(string.Format("Origen: {0}", this.origen));
            return sb.ToString();
        }

        public override string Transformarse()
        {
            if (!this.maximoPoder)
            {
                this.maximoPoder = true;
                this.nivelPoder = (int)(this.nivelPoder * 1.8);
                return "Poder aumentado al maximo";
            }
            return "El poder ya esta al limite";
        }
    }
}
