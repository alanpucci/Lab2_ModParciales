using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Personaje
    {
        protected List<EHabilidades> ataques;
        protected int nivelPoder;
        protected string nombre;

        private Personaje()
        {
            this.ataques = new List<EHabilidades>();
        }

        protected Personaje(string nombre, int nivelPoder)
        {
            this.nombre = nombre;
            this.nivelPoder = nivelPoder;
        }

        protected Personaje(string nombre, int nivelPoder, List<EHabilidades> ataques):this(nombre,nivelPoder)
        {
            this.ataques = ataques;
        }

        protected abstract string Descripcion { get; }

        public abstract string Transformarse();

        public virtual string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre: {0}", this.nombre));
            sb.AppendLine("Lista de ataques:");
            foreach (EHabilidades habilidad in this.ataques)
            {
                sb.AppendLine(string.Format("  Habilidad: {0}", habilidad.ToString()));
            }
            sb.AppendLine(string.Format("Nivel de poder: {0}", this.nivelPoder));
            sb.AppendLine(string.Format("Descripcion: {0}", this.Descripcion));
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator ==(Personaje p1, Personaje p2)
        {
            return p1.GetType() == p2.GetType() && p1.nombre == p2.nombre;
        }

        public static bool operator !=(Personaje p1, Personaje p2)
        {
            return !(p1 == p2);
        }

        public static bool operator == (Personaje p1, List<Personaje> ListaPersonajes)
        {
            foreach (Personaje personaje in ListaPersonajes)
            {
                if(p1 == personaje)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Personaje p1, List<Personaje> ListaPersonajes)
        {
            return !(p1 == ListaPersonajes);
        }
    }
}
