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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private DirectorTecnico directorTecnico;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crea un director tecnico
        /// </summary>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.directorTecnico = new DirectorTecnico(this.txtNombre.Text, this.txtApellido.Text, (int)this.nudEdad.Value, (int)this.nudDni.Value, (int)this.nudExperiencia.Value);
            if(!(this.directorTecnico is null))
            {
                MessageBox.Show("Se ha creado el DT!", "Nuevo DT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Valida que el director tecnico cumpla sus condiciones
        /// </summary>
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (this.directorTecnico is null)
            {
                MessageBox.Show("Aun no se ha creado el DT del formulario", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (this.directorTecnico.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El DT no es apto", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
