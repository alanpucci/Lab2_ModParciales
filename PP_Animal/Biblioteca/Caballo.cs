using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Caballo:Animal
    {
        private bool corredor;

        public Caballo(string nombre, int kilosAlimento, bool corredor):base(nombre,kilosAlimento)
        {
            this.corredor = corredor;
        }

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }

        public override bool ComeBalanceado
        {
            get
            {
                return false;
            }
        }

        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Datos());
            sb.AppendLine(string.Format("Es de carreras: {0}",this.corredor ? "SI" : "NO"));
            return sb.ToString();
        }
    }
}
