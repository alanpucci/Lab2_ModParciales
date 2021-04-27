using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Plastico,
            Vidrio
        }

        private int capacidadML;
        private int contenidoML;
        private string marca;

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            this.contenidoML = capacidadML < contenidoML ? capacidadML : contenidoML;
        }

        public int CapacidadLitro
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (this.Contenido * 100) / this.capacidadML;
            }
        }

        public abstract int ServirMedida();

        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Marca: {this.marca}, Capacidad: {this.capacidadML}ml, Contenido: {this.contenidoML}ml, Porcentaje: {this.PorcentajeContenido}%");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme();
        }
    }
}
