using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace BarForm
{
    public partial class Form1 : Form
    {
        private Bar barcito;
        private decimal oldValue1;
        private decimal oldValue2;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if(this.num1.Value > this.oldValue1)
            {
                Random numRandom = new Random();
                Empleado empleado = new Empleado("Alan", (short)numRandom.Next(1,50));
                if(this.barcito + empleado)
                {

                }
            }
            else
            {
                if(this.oldValue1 > 0)
                {
                    this.barcito.Empleados.RemoveAt(this.barcito.Empleados.Count-1);
                }
            }
            this.richTest.Text = this.barcito.ToString();
            this.oldValue1 = this.num1.Value;
            if (this.barcito.Empleados.Count > 0)
            {
                this.num2.Enabled = true;
            }
            else
            {
                this.num2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.oldValue1 = this.num1.Value;
            this.barcito = new Bar();
            this.num2.Enabled = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
            if (this.num2.Value > this.oldValue2 )
            {
                Random numRandom = new Random();
                Gente gente = new Gente("Pibito", (short)numRandom.Next(1, 50));
                if (this.barcito + gente)
                {
                }
            }
            else
            {
                if (this.oldValue2 > 0)
                {
                    if(this.barcito.Gente.Count > 0)
                    {
                        this.barcito.Gente.RemoveAt(0);
                    }
                }
            }
            this.richTest.Text = this.barcito.ToString();
            this.oldValue2 = this.num2.Value;
            if (this.barcito.Empleados.Count <= (this.barcito.Gente.Count / 10))
            {
                this.num2.Enabled = false;
            }
        }

        private void num1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
