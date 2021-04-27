using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera.PrestamosPersonales
{
    public class PrestamoPesos:Prestamo
    {
        private float porcentajeInteres;

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            :base(monto,vencimiento)
        {
            this.porcentajeInteres = interes;
        }
        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres):this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {
        }

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        private float CalcularInteres()
        {
            return this.monto * (this.porcentajeInteres / 100);
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = (int)(nuevoVencimiento - this.Vencimiento).TotalDays;
            this.porcentajeInteres *= 1.0025f * dias;
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Porcentaje interes: {this.porcentajeInteres}");
            sb.AppendLine($"Interes aplicado: {this.Interes}");
            return sb.ToString();
        }
    }
}
