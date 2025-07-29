namespace EmpleadosPOO
{
    partial class FormContratado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContratado));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.picbackhome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbDuracionContrato = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 150);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(178, 22);
            this.txtnombre.TabIndex = 0;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(309, 150);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(178, 22);
            this.txtpuesto.TabIndex = 1;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(610, 150);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(178, 22);
            this.txtsalario.TabIndex = 2;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(12, 244);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(178, 22);
            this.txtusuario.TabIndex = 3;
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Items.AddRange(new object[] {
            "Temporal",
            "Servicios Profesionales",
            "Honorarios",
            "Por Proyecto"});
            this.cmbTipoContrato.Location = new System.Drawing.Point(610, 244);
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(178, 24);
            this.cmbTipoContrato.TabIndex = 5;
            this.cmbTipoContrato.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picbackhome
            // 
            this.picbackhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbackhome.BackgroundImage")));
            this.picbackhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbackhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbackhome.Location = new System.Drawing.Point(12, 12);
            this.picbackhome.Name = "picbackhome";
            this.picbackhome.Size = new System.Drawing.Size(84, 77);
            this.picbackhome.TabIndex = 17;
            this.picbackhome.TabStop = false;
            this.picbackhome.Click += new System.EventHandler(this.picbackhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "PUESTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "SALARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "USUARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "DURACIÓN CONTRATO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "TIPO DE CONTRATO";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(142, 342);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 24;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(445, 342);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFin.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "FECHA INICIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "FECHA FIN";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(336, 393);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(116, 53);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // cmbDuracionContrato
            // 
            this.cmbDuracionContrato.FormattingEnabled = true;
            this.cmbDuracionContrato.Items.AddRange(new object[] {
            "3 Meses",
            "6 Meses",
            "9 Meses",
            "12 Meses",
            "18 Meses",
            "Indefinido"});
            this.cmbDuracionContrato.Location = new System.Drawing.Point(309, 244);
            this.cmbDuracionContrato.Name = "cmbDuracionContrato";
            this.cmbDuracionContrato.Size = new System.Drawing.Size(178, 24);
            this.cmbDuracionContrato.TabIndex = 29;
            // 
            // FormContratado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.cmbDuracionContrato);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbackhome);
            this.Controls.Add(this.cmbTipoContrato);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.txtnombre);
            this.Name = "FormContratado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESAR EMPLEADO CONTRATADO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContratado_Closing);
            this.Load += new System.EventHandler(this.FormContratado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.PictureBox picbackhome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ComboBox cmbDuracionContrato;
    }
}