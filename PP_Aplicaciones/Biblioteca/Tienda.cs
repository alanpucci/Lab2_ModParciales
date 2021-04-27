using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Tienda
    {
        private static List<Dispositivo> inventario;
        private static string nombreTienda;

        static Tienda()
        {
            inventario = new List<Dispositivo>();
        }

        public static List<Dispositivo> Inventario
        {
            get
            {
                return inventario;
            }
        }

        public static string NombreTienda
        {
            set
            {
                nombreTienda = value;
            }
            get
            {
                return nombreTienda;
            }
        }

        public static bool AgregarDispositivo(Dispositivo unDispositivo)
        {
            if(inventario != unDispositivo)
            {
                inventario.Add(unDispositivo);
                return true;
            }
            return false;
        }

        public static string ListarDispositivos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de la tienda: {nombreTienda}");
            sb.AppendLine("Inventario:");
            foreach (Dispositivo dispositivo in inventario)
            {
                sb.AppendLine(dispositivo.ToString());
            }
            return sb.ToString();
        }
    }
}
