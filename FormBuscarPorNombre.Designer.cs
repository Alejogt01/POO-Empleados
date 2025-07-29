namespace EmpleadosPOO
{
    partial class FormBuscarPorNombre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarPorNombre));
            this.picbackhome = new System.Windows.Forms.PictureBox();
            this.dgvmostrarbusqueda = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrarbusqueda)).BeginInit();
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
            // dgvmostrarbusqueda
            // 
            this.dgvmostrarbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrarbusqueda.Location = new System.Drawing.Point(12, 141);
            this.dgvmostrarbusqueda.Name = "dgvmostrarbusqueda";
            this.dgvmostrarbusqueda.RowHeadersWidth = 51;
            this.dgvmostrarbusqueda.RowTemplate.Height = 24;
            this.dgvmostrarbusqueda.Size = new System.Drawing.Size(776, 163);
            this.dgvmostrarbusqueda.TabIndex = 19;
            this.dgvmostrarbusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmostrarbusqueda_CellContentClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(146, 67);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(257, 22);
            this.txtbuscar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "BUSCAR POR NOMBRE";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(409, 53);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(107, 50);
            this.btnbuscar.TabIndex = 22;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // FormBuscarPorNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgvmostrarbusqueda);
            this.Controls.Add(this.picbackhome);
            this.Name = "FormBuscarPorNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR EMPLEADO POR NOMBRE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuscarPorNombre_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picbackhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrarbusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbackhome;
        private System.Windows.Forms.DataGridView dgvmostrarbusqueda;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
    }
}