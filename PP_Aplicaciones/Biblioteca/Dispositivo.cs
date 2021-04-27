using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Dispositivo
    {
        protected List<Aplicaciones> aplicaciones;
        protected EDuracionBateria bateria;
        protected string nombre;
        protected EResolucionPantalla resolucion;
        protected int stock;

        private Dispositivo()
        {
            this.aplicaciones = new List<Aplicaciones>();
            this.aplicaciones = Aplicaciones.CargarAppsDefecto();
        }

        public Dispositivo(string nombre, EDuracionBateria bateria, EResolucionPantalla resolucion, int stock) : this()
        {
            this.nombre = nombre;
            this.bateria = bateria;
            this.resolucion = resolucion;
            this.stock = stock;
        }

        public List<Aplicaciones> ListaAplicaciones
        {
            get
            {
                return this.aplicaciones;
            }
        }

        public static explicit operator List<Aplicaciones>(Dispositivo unDispositivo)
        {
            return unDispositivo.aplicaciones;
        }

        public static bool operator ==(List<Dispositivo> ListDispositivos, Dispositivo disp)
        {
            foreach (Dispositivo dispositivo in ListDispositivos)
            {
                if(dispositivo == disp)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(List<Dispositivo> ListDispositivos, Dispositivo disp)
        {
            return !(ListDispositivos == disp);
        }

        public abstract bool RestaurarAFabrica();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Bateria: {this.bateria}");
            sb.AppendLine($"Resolucion: {this.resolucion}");
            sb.AppendLine($"Stock: {this.stock}");
            sb.AppendLine("Aplicaicones:");
            foreach (Aplicaciones aplicacion in this.aplicaciones)
            {
                sb.AppendLine(aplicacion.Info);
            }
            return sb.ToString();
        }
    }
}
