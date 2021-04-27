using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo);
            if (this.radioButton1.Checked)
            {
                Cerveza cerveza = new Cerveza((int)this.numCapacidad.Value, this.txtMarca.Text, tipo,(int)this.numContenido.Value);
                this.barra1.AgregarBotella(cerveza);
            }
            else
            {
                Agua agua = new Agua((int)this.numCapacidad.Value, this.txtMarca.Text, (int)this.numContenido.Value);
                this.barra1.AgregarBotella(agua);
            }
        }

        private void barra1_Load(object sender, EventArgs e)
        {
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
