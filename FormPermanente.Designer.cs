namespace EmpleadosPOO
{
    partial class FormPermanente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPermanente));
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbackhome = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(290, 315);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(221, 22);
            this.txtusuario.TabIndex = 15;
            this.txtusuario.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(290, 241);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(221, 22);
            this.txtsalario.TabIndex = 14;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(290, 167);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(221, 22);
            this.txtpuesto.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(290, 92);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(221, 22);
            this.txtnombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SALARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "PUESTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMBRE";
            // 
            // picbackhome
            // 
            this.picbackhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbackhome.BackgroundImage")));
            this.picbackhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbackhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbackhome.Location = new System.Drawing.Point(12, 12);
            this.picbackhome.Name = "picbackhome";
            this.picbackhome.Size = new System.Drawing.Size(84, 77);
            this.picbackhome.TabIndex = 16;
            this.picbackhome.TabStop = false;
            this.picbackhome.Click += new System.EventHandler(this.picbackhome_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(343, 361);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(116, 53);
            this.btnguardar.TabIndex = 17;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // FormPermanente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.picbackhome);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPermanente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AÑADIR EMPLEADO PERMANENTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPermanente_FormClosing);
            this.Load += new System.EventHandler(this.FormPermanente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbackhome;
        private System.Windows.Forms.Button btnguardar;
    }
}