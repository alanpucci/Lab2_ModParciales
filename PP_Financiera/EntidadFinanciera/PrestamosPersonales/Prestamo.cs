using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            set
            {
                if(value.CompareTo(new DateTime()) > 0)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = new DateTime();
                }
            }
            get
            {
                return this.vencimiento;
            }
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Monto: {this.Monto}");
            sb.AppendLine($"Vencimiento: {this.Vencimiento}");
            return sb.ToString();
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return p1.Vencimiento.CompareTo(p2.Vencimiento);
        }
    }
}
