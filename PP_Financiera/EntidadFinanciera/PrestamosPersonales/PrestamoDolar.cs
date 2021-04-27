using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera.PrestamosPersonales
{
    public class PrestamoDolar:Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            :base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad):this(prestamo.Monto,prestamo.Vencimiento,periodicidad)
        {

        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
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
            float interes = 0;
            switch (this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    interes = this.monto * 1.25f;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    interes = this.monto * 1.35f;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    interes = this.monto * 1.40f;
                    break;
            }
            return interes;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = (int)(nuevoVencimiento - this.Vencimiento).TotalDays;
            this.monto += (2.5f * dias);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Periodicidad: {this.periodicidad}");
            return sb.ToString();
        }
    }
}
