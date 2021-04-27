using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class DragonBall
    {
        private static List<Personaje> listaPersonaje;

        static DragonBall()
        {
            listaPersonaje = new List<Personaje>();
        }

        public static List<Personaje> ListaPersonaje
        {
            get
            {
                return listaPersonaje;
            }
        }

        public static bool AgregarPersonaje(Personaje p1)
        {
            bool retorno = true;
            foreach (Personaje personaje in listaPersonaje)
            {
                if(personaje == personaje)
                {
                    retorno = false;
                }
            }
            if (retorno)
            {
                listaPersonaje.Add(p1);
            }
            return retorno;
        }

        private static void CargarDatosDefault()
        {
            List<EHabilidades> habilidades = new List<EHabilidades>();
            habilidades.Add(EHabilidades.GenkiDama);
            habilidades.Add(EHabilidades.Kamehameha);
            listaPersonaje.Add(new Heroe("Goku", 300, habilidades, true));
            listaPersonaje.Add(new Heroe("Gohan", 200, habilidades, true));
            listaPersonaje.Add(new Heroe("Krillin", 100, habilidades, false));
        }

    }
}
