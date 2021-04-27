
namespace VistaForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCurso = new System.Windows.Forms.GroupBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grpAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.cmbDivisionAlumno = new System.Windows.Forms.ComboBox();
            this.lblDniAlumno = new System.Windows.Forms.Label();
            this.lblApellidoAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblDivisionAlumno = new System.Windows.Forms.Label();
            this.lblAnioAlumno = new System.Windows.Forms.Label();
            this.nudAnioAlumno = new System.Windows.Forms.NumericUpDown();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.grpCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.grpAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCurso
            // 
            this.grpCurso.Controls.Add(this.btnMostrar);
            this.grpCurso.Controls.Add(this.btnCrear);
            this.grpCurso.Controls.Add(this.dtpIngreso);
            this.grpCurso.Controls.Add(this.txtDni);
            this.grpCurso.Controls.Add(this.txtApellido);
            this.grpCurso.Controls.Add(this.txtNombre);
            this.grpCurso.Controls.Add(this.cmbDivision);
            this.grpCurso.Controls.Add(this.lblIngreso);
            this.grpCurso.Controls.Add(this.lblDni);
            this.grpCurso.Controls.Add(this.lblApellido);
            this.grpCurso.Controls.Add(this.lblNombre);
            this.grpCurso.Controls.Add(this.lblDivision);
            this.grpCurso.Controls.Add(this.lblAnio);
            this.grpCurso.Controls.Add(this.nudAnio);
            this.grpCurso.Location = new System.Drawing.Point(12, 12);
            this.grpCurso.Name = "grpCurso";
            this.grpCurso.Size = new System.Drawing.Size(386, 252);
            this.grpCurso.TabIndex = 0;
            this.grpCurso.TabStop = false;
            this.grpCurso.Text = "Datos Curso";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(129, 22);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(233, 20);
            this.nudAnio.TabIndex = 0;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(30, 22);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 17);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "Año";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(28, 49);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(57, 17);
            this.lblDivision.TabIndex = 2;
            this.lblDivision.Text = "Division";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(27, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(27, 144);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 17);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(27, 175);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(55, 17);
            this.lblIngreso.TabIndex = 6;
            this.lblIngreso.Text = "Ingreso";
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(128, 49);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(234, 21);
            this.cmbDivision.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(129, 111);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(233, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(128, 144);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(234, 20);
            this.txtDni.TabIndex = 4;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(128, 175);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(234, 20);
            this.dtpIngreso.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(30, 204);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(141, 42);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(221, 204);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(141, 42);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // grpAlumno
            // 
            this.grpAlumno.Controls.Add(this.btnAgregar);
            this.grpAlumno.Controls.Add(this.nudAnioAlumno);
            this.grpAlumno.Controls.Add(this.lblAnioAlumno);
            this.grpAlumno.Controls.Add(this.txtDniAlumno);
            this.grpAlumno.Controls.Add(this.txtApellidoAlumno);
            this.grpAlumno.Controls.Add(this.txtNombreAlumno);
            this.grpAlumno.Controls.Add(this.cmbDivisionAlumno);
            this.grpAlumno.Controls.Add(this.lblDniAlumno);
            this.grpAlumno.Controls.Add(this.lblApellidoAlumno);
            this.grpAlumno.Controls.Add(this.lblNombreAlumno);
            this.grpAlumno.Controls.Add(this.lblDivisionAlumno);
            this.grpAlumno.Location = new System.Drawing.Point(404, 12);
            this.grpAlumno.Name = "grpAlumno";
            this.grpAlumno.Size = new System.Drawing.Size(386, 252);
            this.grpAlumno.TabIndex = 13;
            this.grpAlumno.TabStop = false;
            this.grpAlumno.Text = "Datos Alumno";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(221, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 42);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(130, 85);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(234, 20);
            this.txtDniAlumno.TabIndex = 10;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(130, 55);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(233, 20);
            this.txtApellidoAlumno.TabIndex = 9;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(129, 25);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(234, 20);
            this.txtNombreAlumno.TabIndex = 8;
            // 
            // cmbDivisionAlumno
            // 
            this.cmbDivisionAlumno.FormattingEnabled = true;
            this.cmbDivisionAlumno.Location = new System.Drawing.Point(130, 144);
            this.cmbDivisionAlumno.Name = "cmbDivisionAlumno";
            this.cmbDivisionAlumno.Size = new System.Drawing.Size(234, 21);
            this.cmbDivisionAlumno.TabIndex = 12;
            // 
            // lblDniAlumno
            // 
            this.lblDniAlumno.AutoSize = true;
            this.lblDniAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniAlumno.Location = new System.Drawing.Point(28, 85);
            this.lblDniAlumno.Name = "lblDniAlumno";
            this.lblDniAlumno.Size = new System.Drawing.Size(31, 17);
            this.lblDniAlumno.TabIndex = 5;
            this.lblDniAlumno.Text = "DNI";
            // 
            // lblApellidoAlumno
            // 
            this.lblApellidoAlumno.AutoSize = true;
            this.lblApellidoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoAlumno.Location = new System.Drawing.Point(28, 53);
            this.lblApellidoAlumno.Name = "lblApellidoAlumno";
            this.lblApellidoAlumno.Size = new System.Drawing.Size(58, 17);
            this.lblApellidoAlumno.TabIndex = 4;
            this.lblApellidoAlumno.Text = "Apellido";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(28, 25);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(58, 17);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // lblDivisionAlumno
            // 
            this.lblDivisionAlumno.AutoSize = true;
            this.lblDivisionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisionAlumno.Location = new System.Drawing.Point(27, 145);
            this.lblDivisionAlumno.Name = "lblDivisionAlumno";
            this.lblDivisionAlumno.Size = new System.Drawing.Size(57, 17);
            this.lblDivisionAlumno.TabIndex = 2;
            this.lblDivisionAlumno.Text = "Division";
            // 
            // lblAnioAlumno
            // 
            this.lblAnioAlumno.AutoSize = true;
            this.lblAnioAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioAlumno.Location = new System.Drawing.Point(28, 117);
            this.lblAnioAlumno.Name = "lblAnioAlumno";
            this.lblAnioAlumno.Size = new System.Drawing.Size(33, 17);
            this.lblAnioAlumno.TabIndex = 1;
            this.lblAnioAlumno.Text = "Año";
            // 
            // nudAnioAlumno
            // 
            this.nudAnioAlumno.Location = new System.Drawing.Point(130, 114);
            this.nudAnioAlumno.Name = "nudAnioAlumno";
            this.nudAnioAlumno.Size = new System.Drawing.Size(234, 20);
            this.nudAnioAlumno.TabIndex = 11;
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 270);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(776, 278);
            this.rtbDatos.TabIndex = 14;
            this.rtbDatos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.grpAlumno);
            this.Controls.Add(this.grpCurso);
            this.Name = "Form1";
            this.Text = "Vista del Curso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCurso.ResumeLayout(false);
            this.grpCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.grpAlumno.ResumeLayout(false);
            this.grpAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCurso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.GroupBox grpAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudAnioAlumno;
        private System.Windows.Forms.Label lblAnioAlumno;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.ComboBox cmbDivisionAlumno;
        private System.Windows.Forms.Label lblDniAlumno;
        private System.Windows.Forms.Label lblApellidoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblDivisionAlumno;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

