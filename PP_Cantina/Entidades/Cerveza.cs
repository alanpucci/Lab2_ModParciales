using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML):base(marca, capacidadML, contenidoML)
        {
            this.tipo = Tipo.Vidrio;
        }
        public Cerveza(int capacidadML, string marca, Tipo tipo,int contenidoML):this(capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        protected new string GenerarInforme()
        {
            return base.ToString();
        }

        public override int ServirMedida()
        {
            if (MEDIDA <= base.Contenido)
            {
                base.Contenido = base.Contenido - ((MEDIDA * 80) / 100);
                return ((MEDIDA * 80) / 100);
            }
            else
            {
                return base.Contenido = 0;
            }
        }
    }
}
