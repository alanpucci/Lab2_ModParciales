using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        protected Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores { get; }

        public abstract bool TieneFruto { get; }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{this.nombre} tiene un tamaño de {this.tamanio}"));
            sb.AppendLine(string.Format("Tiene flores {0}", this.TieneFlores ? "SI" : "N0"));
            sb.AppendLine(string.Format("Tiene fruto {0}", this.TieneFruto ? "SI" : "NO"));
            return sb.ToString();
        }

    }
}
