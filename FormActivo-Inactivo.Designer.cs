namespace EmpleadosPOO
{
    partial class FormActivo_Inactivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivo_Inactivo));
            this.picbackhome = new System.Windows.Forms.PictureBox();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // picbackhome
            // 
            this.picbackhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbackhome.BackgroundImage")));
            this.picbackhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbackhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbackhome.Location = new System.Drawing.Point(12, 12);
            this.picbackhome.Name = "picbackhome";
            this.picbackhome.Size = new System.Drawing.Size(84, 77);
            this.picbackhome.TabIndex = 18;
            this.picbackhome.TabStop = false;
            this.picbackhome.Click += new System.EventHandler(this.picbackhome_Click);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(12, 125);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.RowHeadersWidth = 51;
            this.dgvmostrar.RowTemplate.Height = 24;
            this.dgvmostrar.Size = new System.Drawing.Size(776, 179);
            this.dgvmostrar.TabIndex = 19;
            // 
            // FormActivo_Inactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.picbackhome);
            this.Name = "FormActivo_Inactivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADO ACTIVO/INACTIVO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormActivo_Inactivo_Closing);
            this.Load += new System.EventHandler(this.FormActivo_Inactivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbackhome;
        private System.Windows.Forms.DataGridView dgvmostrar;
    }
}