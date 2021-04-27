
namespace FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.barra1 = new ControlCantina.Barra();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblContenido);
            this.panel1.Controls.Add(this.lblCapacidad);
            this.panel1.Controls.Add(this.numContenido);
            this.panel1.Controls.Add(this.numCapacidad);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 132);
            this.panel1.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(358, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(63, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Botella Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(361, 42);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 9;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(361, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 41);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(225, 78);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 7;
            this.lblContenido.Text = "Contenido";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(120, 78);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 6;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(228, 94);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(81, 20);
            this.numContenido.TabIndex = 5;
            this.numContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(123, 94);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(81, 20);
            this.numCapacidad.TabIndex = 4;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(120, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(123, 41);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(186, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Agua";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cerveza";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(0, -2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 367);
            this.barra1.TabIndex = 0;
            this.barra1.Load += new System.EventHandler(this.barra1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

