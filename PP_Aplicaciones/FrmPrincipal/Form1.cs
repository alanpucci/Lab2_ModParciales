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

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            EDuracionBateria bateria;
            EResolucionPantalla resolucion;
            ETipoPantalla tipoPantalla;
            Enum.TryParse<EDuracionBateria>(this.cmbBateria.SelectedValue.ToString(), out bateria);
            Enum.TryParse<EResolucionPantalla>(this.cmbResolucion.SelectedValue.ToString(), out resolucion);
            Enum.TryParse<ETipoPantalla>(this.cmbTipo.SelectedValue.ToString(), out tipoPantalla);
            if(this.cmbTipoDisp.SelectedIndex == 0)
            {
                Tienda.AgregarDispositivo(new Celular(this.txtNombre.Text, bateria, resolucion, (int)this.nudStock.Value, (int)this.nudCamaras.Value, (int)this.nudResolucion.Value));
                MessageBox.Show("Se agregó un celular!", "Carga exitosa", MessageBoxButtons.OK);
            }
            else
            {
                Tienda.AgregarDispositivo(new Tablet(this.txtNombre.Text, bateria, resolucion, (int)this.nudStock.Value, tipoPantalla, true));
                MessageBox.Show("Se agregó una tablet!", "Carga exitosa", MessageBoxButtons.OK);
            }
            this.cmbInventario.Items.Add(this.txtNombre.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbBateria.DataSource = Enum.GetValues(typeof(EDuracionBateria));
            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipoPantalla));
            this.cmbResolucion.DataSource = Enum.GetValues(typeof(EResolucionPantalla));
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Text = Tienda.ListarDispositivos();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Tienda.Inventario[this.cmbInventario.SelectedIndex].RestaurarAFabrica();
            MessageBox.Show("Se restauro de fabrica exitosamente!", "Carga exitosa", MessageBoxButtons.OK);
        }

        private void cmbInventario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbTipoDisp.SelectedIndex == 0)
            {
                this.cmbTipo.Enabled = false;
                this.nudCamaras.Enabled = true;
                this.nudResolucion.Enabled = true;
            }
            else
            {
                this.cmbTipo.Enabled = true;
                this.nudCamaras.Enabled = false;
                this.nudResolucion.Enabled = false;
            }
        }
    }
}
