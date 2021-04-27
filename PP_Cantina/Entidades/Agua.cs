using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua: Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML):base(marca,capacidadML,contenidoML)
        {

        }

        public override int ServirMedida()
        {
            if (MEDIDA <= base.Contenido)
            {
                base.Contenido = base.Contenido - MEDIDA;
                return MEDIDA;
            }
            return base.Contenido -= base.Contenido;
        }

        public int ServirMedida(int medida)
        {
            if(medida < MEDIDA)
            {
                return this.ServirMedida();
            }
            return base.Contenido = base.Contenido - medida;
        }

        public new string GenerarInforme()
        {
            return base.ToString();
        }

    }
}
