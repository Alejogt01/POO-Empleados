namespace EmpleadosPOO
{
    partial class FormMenú
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenú));
            this.picsalir = new System.Windows.Forms.PictureBox();
            this.picmostrar = new System.Windows.Forms.PictureBox();
            this.picbuscarempleado = new System.Windows.Forms.PictureBox();
            this.piccontratado = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picpermanente = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccontratado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpermanente)).BeginInit();
            this.SuspendLayout();
            // 
            // picsalir
            // 
            this.picsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picsalir.BackgroundImage")));
            this.picsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picsalir.Location = new System.Drawing.Point(359, 377);
            this.picsalir.Name = "picsalir";
            this.picsalir.Size = new System.Drawing.Size(70, 55);
            this.picsalir.TabIndex = 20;
            this.picsalir.TabStop = false;
            this.picsalir.Click += new System.EventHandler(this.picsalir_Click);
            // 
            // picmostrar
            // 
            this.picmostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picmostrar.BackgroundImage")));
            this.picmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picmostrar.Location = new System.Drawing.Point(359, 292);
            this.picmostrar.Name = "picmostrar";
            this.picmostrar.Size = new System.Drawing.Size(70, 55);
            this.picmostrar.TabIndex = 19;
            this.picmostrar.TabStop = false;
            this.picmostrar.Click += new System.EventHandler(this.picmostrar_Click);
            // 
            // picbuscarempleado
            // 
            this.picbuscarempleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbuscarempleado.BackgroundImage")));
            this.picbuscarempleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbuscarempleado.Location = new System.Drawing.Point(359, 207);
            this.picbuscarempleado.Name = "picbuscarempleado";
            this.picbuscarempleado.Size = new System.Drawing.Size(70, 55);
            this.picbuscarempleado.TabIndex = 18;
            this.picbuscarempleado.TabStop = false;
            this.picbuscarempleado.Click += new System.EventHandler(this.picbuscarempleado_Click);
            // 
            // piccontratado
            // 
            this.piccontratado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piccontratado.BackgroundImage")));
            this.piccontratado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piccontratado.Location = new System.Drawing.Point(359, 122);
            this.piccontratado.Name = "piccontratado";
            this.piccontratado.Size = new System.Drawing.Size(70, 55);
            this.piccontratado.TabIndex = 17;
            this.piccontratado.TabStop = false;
            this.piccontratado.Click += new System.EventHandler(this.piccontratado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "SALIR";
            // 
            // picpermanente
            // 
            this.picpermanente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picpermanente.BackgroundImage")));
            this.picpermanente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picpermanente.Location = new System.Drawing.Point(359, 37);
            this.picpermanente.Name = "picpermanente";
            this.picpermanente.Size = new System.Drawing.Size(70, 55);
            this.picpermanente.TabIndex = 15;
            this.picpermanente.TabStop = false;
            this.picpermanente.Click += new System.EventHandler(this.picpermanente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "MOSTRAR EMPLEADOS ACTIVOS/INACTIVOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "BUSCAR EMPLEADO POR NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "INGRESAR EMPLEADO CONTRATADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "INGRESAR EMPLEADO PERMANENTE";
            // 
            // FormMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picsalir);
            this.Controls.Add(this.picmostrar);
            this.Controls.Add(this.picbuscarempleado);
            this.Controls.Add(this.piccontratado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picpermanente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenú_FormClosing);
            this.Load += new System.EventHandler(this.FormMenú_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccontratado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpermanente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picsalir;
        private System.Windows.Forms.PictureBox picmostrar;
        private System.Windows.Forms.PictureBox picbuscarempleado;
        private System.Windows.Forms.PictureBox piccontratado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picpermanente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

