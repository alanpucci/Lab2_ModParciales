using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public static Cantina GetCantina(int espacios)
        {
            if(Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
            }
            return Cantina.singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if (c.Botellas.Count() < c.espaciosTotales)
            {
                c.botellas.Add(b);
                return true;
            }
            return false;
        }
    }
}
