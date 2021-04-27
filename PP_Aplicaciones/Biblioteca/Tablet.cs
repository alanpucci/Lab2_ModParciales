using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Tablet:Dispositivo
    {
        private bool memoriaExpandible;
        private ETipoPantalla tipoPantalla;

        public Tablet(string nombre, EDuracionBateria bateria, EResolucionPantalla resolucion, int stock, ETipoPantalla tipoPantalla, bool memoriaExpandible):base(nombre, bateria, resolucion, stock)
        {
            this.memoriaExpandible = memoriaExpandible;
            this.tipoPantalla = tipoPantalla;
        }

        public override bool RestaurarAFabrica()
        {
            this.nombre = $"Restaurando Tablet {this.nombre}";
            this.memoriaExpandible = false;
            this.aplicaciones.Clear();
            this.aplicaciones = Aplicaciones.CargarAppsDefecto();
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("Memoria expandible: {0}", this.memoriaExpandible ? "SI" : "NO"));
            sb.AppendLine($"Tipo de pantalla: {this.tipoPantalla}");
            return sb.ToString();
        }
    }
}
