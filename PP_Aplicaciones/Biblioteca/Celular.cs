using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Celular:Dispositivo
    {
        private int cantidadCamaras;
        private int resolucionMaximaCamara;

        public Celular(string nombre, EDuracionBateria bateria, EResolucionPantalla resolucion, int stock, int cantidadCamaras,int resolucionMaximaCamara):base(nombre, bateria, resolucion,stock)
        {
            this.cantidadCamaras = cantidadCamaras;
            this.resolucionMaximaCamara = resolucionMaximaCamara;
        }

        public override bool RestaurarAFabrica()
        {
            this.resolucionMaximaCamara = 5;
            this.cantidadCamaras = 1;
            this.aplicaciones.Clear();
            this.aplicaciones = Aplicaciones.CargarAppsDefecto();
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cantidad camaras: {this.cantidadCamaras}");
            sb.AppendLine($"Resolucion maxima: {this.resolucionMaximaCamara}");
            return sb.ToString();
        }
    }
}
