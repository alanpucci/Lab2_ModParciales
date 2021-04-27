using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Animal
    {
        private int kilosAlimento;
        private string nombre;

        public Animal(string nombre, int volumen)
        {
            this.nombre = nombre;
            this.kilosAlimento = volumen;
        }

        public int KilosAlimento
        {
            get
            {
                return this.kilosAlimento;
            }
        }

        public abstract bool ComeBalanceado { get; }
        public abstract bool ComePasto { get; }

        public virtual string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} come {1}kg",this.nombre, this.KilosAlimento));
            sb.AppendLine(string.Format("Consume balanceado? {0}",this.ComeBalanceado ? "SI" : "NO"));
            sb.AppendLine(string.Format("Consume pasto? {0}",this.ComePasto ? "SI" : "NO"));
            return sb.ToString();
        }
    }
}
