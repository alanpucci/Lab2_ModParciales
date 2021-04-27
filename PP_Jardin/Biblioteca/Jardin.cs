using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        private static Tipo suelo;
        private int espacioTotal;
        private List<Planta> plantas;

        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal):this()
        {
            this.espacioTotal = espacioTotal;
        }

        public Tipo TipoSuelo
        {
            set
            {
                suelo = value;
            }
        }

        private int EspacioOcupado()
        {
            int cantidad = 0;
            foreach(Planta planta in this.plantas)
            {
                cantidad += planta.Tamanio;
            }
            return cantidad;
        }

        private int EspacioOcupado(Planta planta)
        {
            int cantidad = this.EspacioOcupado();
            cantidad += planta.Tamanio;
            return cantidad;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if(jardin.EspacioOcupado(planta) <= jardin.espacioTotal)
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composicion del jardin: {suelo}");
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}");
            foreach(Planta planta in this.plantas)
            {
                sb.AppendLine(planta.ResumenDeDatos());
            }
            return sb.ToString();
        }
    }
}
