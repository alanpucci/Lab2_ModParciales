using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Campo
    {
        public enum Tipo
        {
            Pastoreo,
            Engorde
        }

        private int alimentoDisponible;
        private List<Animal> animales;
        private static Tipo servicio;

        static Campo()
        {
            servicio = Tipo.Engorde;
        }

        private Campo()
        {
            this.animales = new List<Animal>();
        }

        public Campo(int alimento):this()
        {
            this.alimentoDisponible = alimento;
        }

        public static Tipo TipoServicio
        {
            set
            {
                servicio = value;
            }
        }

        private int AlimentoComprometido()
        {
            int acumulador = 0;
            foreach (Animal animal in this.animales)
            {
                acumulador += animal.KilosAlimento;
            }
            return acumulador;
        }

        private int AlimentoComprometido(Animal animal)
        {
            return this.AlimentoComprometido() + animal.KilosAlimento;
        }

        public static bool operator +(Campo campo, Animal animal)
        {
            if(campo.alimentoDisponible >= campo.AlimentoComprometido(animal))
            {
                campo.animales.Add(animal);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Servicio del campo: {0}", servicio));
            sb.AppendLine(string.Format("Alimento comprometido {0} de {1}", this.AlimentoComprometido(), this.alimentoDisponible));
            foreach (Animal animal in this.animales)
            {
                sb.AppendLine(animal.Datos());
            }
            return sb.ToString();
        }


    }
}
