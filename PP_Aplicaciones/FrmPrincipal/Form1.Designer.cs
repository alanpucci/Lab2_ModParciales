
namespace FrmPrincipal
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
            this.grpDisp = new System.Windows.Forms.GroupBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbResolucion = new System.Windows.Forms.ComboBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.cmbBateria = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoDisp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudResolucion = new System.Windows.Forms.NumericUpDown();
            this.btnInforme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInventario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCamaras = new System.Windows.Forms.NumericUpDown();
            this.grpDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamaras)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDisp
            // 
            this.grpDisp.BackColor = System.Drawing.Color.Gainsboro;
            this.grpDisp.Controls.Add(this.nudCamaras);
            this.grpDisp.Controls.Add(this.label9);
            this.grpDisp.Controls.Add(this.cmbInventario);
            this.grpDisp.Controls.Add(this.label6);
            this.grpDisp.Controls.Add(this.btnInforme);
            this.grpDisp.Controls.Add(this.nudResolucion);
            this.grpDisp.Controls.Add(this.label8);
            this.grpDisp.Controls.Add(this.cmbTipoDisp);
            this.grpDisp.Controls.Add(this.btnRestaurar);
            this.grpDisp.Controls.Add(this.label7);
            this.grpDisp.Controls.Add(this.btnCrear);
            this.grpDisp.Controls.Add(this.cmbTipo);
            this.grpDisp.Controls.Add(this.cmbResolucion);
            this.grpDisp.Controls.Add(this.nudStock);
            this.grpDisp.Controls.Add(this.cmbBateria);
            this.grpDisp.Controls.Add(this.txtNombre);
            this.grpDisp.Controls.Add(this.label5);
            this.grpDisp.Controls.Add(this.label4);
            this.grpDisp.Controls.Add(this.label3);
            this.grpDisp.Controls.Add(this.label2);
            this.grpDisp.Controls.Add(this.label1);
            this.grpDisp.Location = new System.Drawing.Point(12, 12);
            this.grpDisp.Name = "grpDisp";
            this.grpDisp.Size = new System.Drawing.Size(354, 452);
            this.grpDisp.TabIndex = 0;
            this.grpDisp.TabStop = false;
            this.grpDisp.Text = "Dispositivo";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(125, 396);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(107, 40);
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(6, 396);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(113, 40);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(171, 223);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(154, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // cmbResolucion
            // 
            this.cmbResolucion.FormattingEnabled = true;
            this.cmbResolucion.Location = new System.Drawing.Point(171, 180);
            this.cmbResolucion.Name = "cmbResolucion";
            this.cmbResolucion.Size = new System.Drawing.Size(154, 21);
            this.cmbResolucion.TabIndex = 8;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(171, 141);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(154, 20);
            this.nudStock.TabIndex = 7;
            // 
            // cmbBateria
            // 
            this.cmbBateria.FormattingEnabled = true;
            this.cmbBateria.Location = new System.Drawing.Point(171, 102);
            this.cmbBateria.Name = "cmbBateria";
            this.cmbBateria.Size = new System.Drawing.Size(154, 21);
            this.cmbBateria.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo pantalla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resolucion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bateria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // rtbInforme
            // 
            this.rtbInforme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbInforme.Location = new System.Drawing.Point(372, 12);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(352, 452);
            this.rtbInforme.TabIndex = 14;
            this.rtbInforme.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dispositivo";
            // 
            // cmbTipoDisp
            // 
            this.cmbTipoDisp.FormattingEnabled = true;
            this.cmbTipoDisp.Items.AddRange(new object[] {
            "Celular",
            "Tablet"});
            this.cmbTipoDisp.Location = new System.Drawing.Point(171, 21);
            this.cmbTipoDisp.Name = "cmbTipoDisp";
            this.cmbTipoDisp.Size = new System.Drawing.Size(154, 21);
            this.cmbTipoDisp.TabIndex = 13;
            this.cmbTipoDisp.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDisp_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resolucion maxima";
            // 
            // nudResolucion
            // 
            this.nudResolucion.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudResolucion.Location = new System.Drawing.Point(171, 262);
            this.nudResolucion.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudResolucion.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudResolucion.Name = "nudResolucion";
            this.nudResolucion.Size = new System.Drawing.Size(154, 20);
            this.nudResolucion.TabIndex = 15;
            this.nudResolucion.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(241, 396);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(107, 40);
            this.btnInforme.TabIndex = 13;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Inventario";
            // 
            // cmbInventario
            // 
            this.cmbInventario.FormattingEnabled = true;
            this.cmbInventario.Location = new System.Drawing.Point(171, 346);
            this.cmbInventario.Name = "cmbInventario";
            this.cmbInventario.Size = new System.Drawing.Size(154, 21);
            this.cmbInventario.TabIndex = 17;
            this.cmbInventario.SelectedIndexChanged += new System.EventHandler(this.cmbInventario_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad de camaras";
            // 
            // nudCamaras
            // 
            this.nudCamaras.Location = new System.Drawing.Point(171, 306);
            this.nudCamaras.Name = "nudCamaras";
            this.nudCamaras.Size = new System.Drawing.Size(154, 20);
            this.nudCamaras.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(732, 476);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.grpDisp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDisp.ResumeLayout(false);
            this.grpDisp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamaras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDisp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbResolucion;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.ComboBox cmbBateria;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.ComboBox cmbTipoDisp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudResolucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.ComboBox cmbInventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCamaras;
        private System.Windows.Forms.Label label9;
    }
}

