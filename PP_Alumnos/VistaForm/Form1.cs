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
        private Curso curso;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crea el curso
        /// </summary>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(this.cmbDivision.SelectedValue.ToString(), out division);
            this.curso = new Curso((short)this.nudAnio.Value, division, new Profesor(this.txtNombre.Text, this.txtApellido.Text,this.txtDni.Text, this.dtpIngreso.Value));
        }

        /// <summary>
        /// Carga los combobox del curso y de alumno
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            this.cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        /// <summary>
        /// Muestra los datos del curso y los alumnos
        /// </summary>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(this.curso is null)
            {
                MessageBox.Show("Debes crear un curso!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.rtbDatos.Text = (string)this.curso;
        }

        /// <summary>
        /// Crea un alumno y lo agrega dentro del curso
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(this.cmbDivisionAlumno.SelectedValue.ToString(), out division);
            Alumno alumno = new Alumno(this.txtNombreAlumno.Text, this.txtApellidoAlumno.Text, this.txtDniAlumno.Text, (short)this.nudAnioAlumno.Value, division);
            this.curso += alumno;
        }
    }
}
