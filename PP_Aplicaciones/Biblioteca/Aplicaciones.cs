using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Aplicaciones
    {
        private string nombre;
        private int tamañoApp;

        public Aplicaciones(string nombre, int tamañoApp)
        {
            this.nombre = nombre;
            this.tamañoApp = tamañoApp;
        }

        public string Info
        {
            get
            {
                return string.Format("App: {0}, Tamaño: {1}MB", this.nombre, this.tamañoApp);
            }
        }

        public static List<Aplicaciones> CargarAppsDefecto()
        {
            List<Aplicaciones> listaAplicaciones = new List<Aplicaciones>();
            listaAplicaciones.Add(new Aplicaciones("Navegador", 10));
            listaAplicaciones.Add(new Aplicaciones("Emails", 15));
            return listaAplicaciones;
        }
    }
}
