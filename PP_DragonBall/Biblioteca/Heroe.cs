using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Heroe:Personaje
    {
        private bool esSaiyan;
        private EtransformacionSaiyan transformacion;

        public Heroe(string nombre, int nivelPoder, List<EHabilidades> ataques, bool esSaiyan):base(nombre, nivelPoder, ataques)
        {
            this.esSaiyan = esSaiyan;
        }

        protected override string Descripcion
        {
            get
            {
                return this.esSaiyan ? "Disfruta los combates. Su poder no tiene limite" : "Siempre pelea junto a un Saiyan.Fiel amigo";
            }
        }

        public override string Transformarse()
        {
            if (this.esSaiyan)
            {
                switch (this.transformacion)
                {
                    case EtransformacionSaiyan.Base:
                        this.nivelPoder = 100;
                        this.transformacion++;
                        this.nivelPoder *= 10;
                        break;
                    case EtransformacionSaiyan.SSJ:
                        this.transformacion++;
                        this.nivelPoder *= 20;
                        break;
                    case EtransformacionSaiyan.SSJ2:
                        this.transformacion++;
                        this.nivelPoder *= 30;
                        break;
                    case EtransformacionSaiyan.SSJ3:
                        this.transformacion++;
                        this.nivelPoder = 100;
                        break;
                }
            }
            return $"Me transforme a {this.transformacion}";
        }

        public override string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.InfoPersonaje());
            sb.AppendLine(string.Format("Soy saiyan: {0}",this.esSaiyan ? "SI" : "NO"));
            sb.AppendLine(string.Format("Transformacion: {0}",this.transformacion.ToString()));
            return sb.ToString();
        }
    }
}
