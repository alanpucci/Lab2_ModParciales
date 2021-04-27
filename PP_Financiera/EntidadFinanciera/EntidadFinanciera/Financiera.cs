using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFinanciera.PrestamosPersonales;

namespace EntidadFinanciera.EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesEnDolares
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float interesGanado=0;
            foreach (Prestamo prestamo in this.ListaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case TipoDePrestamo.Pesos:
                        if (prestamo is PrestamoPesos)
                        {
                            interesGanado += ((PrestamoPesos)prestamo).Interes;
                        }
                        break;
                    case TipoDePrestamo.Dolares:
                        if (prestamo is PrestamoDolar)
                        {
                            interesGanado += ((PrestamoDolar)prestamo).Interes;
                        }
                        break;
                    case TipoDePrestamo.Todos:
                        if (prestamo is PrestamoPesos)
                        {
                            interesGanado += ((PrestamoPesos)prestamo).Interes;
                        }
                        if (prestamo is PrestamoDolar)
                        {
                            interesGanado += ((PrestamoDolar)prestamo).Interes;
                        }
                        break;
                }
            }
            return interesGanado;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (String)financiera;
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {financiera.RazonSocial}");
            sb.AppendLine($"Interes total: {financiera.InteresesTotales}");
            sb.AppendLine($"Interes pesos: {financiera.InteresesEnPesos}");
            sb.AppendLine($"Interes dolar: {financiera.InteresesEnDolares}");
            financiera.OrdenarPrestamos();
            foreach (Prestamo prestamo in financiera.ListaDePrestamos)
            {
                sb.AppendLine(prestamo.Mostrar());
            }
            return sb.ToString();
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            foreach (Prestamo prestamo1 in financiera.ListaDePrestamos)
            {
                if(prestamo == prestamo1)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if(financiera != prestamoNuevo)
            {
                financiera.ListaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }
    }
}
