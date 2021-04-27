using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Receta
    {
        public enum Tipo
        {
            Clasica,
            Especial
        }

        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        static Receta()
        {
            preparacion = Tipo.Clasica;
        }

        private Receta()
        {
            this.ingredientes = new List<Ingrediente>();
        }

        public Receta(int capacidad):this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        public Tipo TipoDePreparacion
        {
            set
            {
                preparacion = value;
            }
        }

        private int CapacidadLibre()
        {
            int acumulador = 0;
            foreach (Ingrediente ingrediente in this.ingredientes)
            {
                acumulador += ingrediente.Cantidad;
            }
            return this.capacidadDelContenedor - acumulador;
        }

        private int CapacidadLibre(Ingrediente planta)
        {
            return this.CapacidadLibre() - planta.Cantidad;
        }

        public static bool operator + (Receta receta, Ingrediente ingrediente)
        {
            if(receta.CapacidadLibre(ingrediente) >= 0)
            {
                receta.ingredientes.Add(ingrediente);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Receta: {preparacion}"));
            sb.AppendLine(string.Format($"Capacidad libre: {this.CapacidadLibre()}"));
            sb.AppendLine(string.Format($"Capacidad total: {this.capacidadDelContenedor}"));
            foreach (Ingrediente ingrediente in this.ingredientes)
            {
                sb.AppendLine(ingrediente.Informacion());
            }
            return sb.ToString();
        }
    }
}
