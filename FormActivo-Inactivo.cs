using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmpleadosPOO
{
    public partial class FormActivo_Inactivo : Form
    {
        private List<Empleado> empleados = new List<Empleado>();

        public FormActivo_Inactivo()
        {
            InitializeComponent();
        }

        public FormActivo_Inactivo(List<Empleado> empleadosRegistrados)
        {
            InitializeComponent();
            empleados = empleadosRegistrados;
        }

        private void FormActivo_Inactivo_Load(object sender, EventArgs e)
        {
            // Configuracion del DataGridView para no generar columnas automáticas
            dgvmostrar.AutoGenerateColumns = false;
            dgvmostrar.Columns.Clear();

            // Columna Nombre
            dgvmostrar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });

            // Columna Usuario
            dgvmostrar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Usuario",
                HeaderText = "Usuario"
            });

            // Columna Activo (checkbox)
            dgvmostrar.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Activo",
                HeaderText = "Activo"
            });

            // Asigna la lista como origen de datos
            dgvmostrar.DataSource = null;
            dgvmostrar.DataSource = empleados;
        }

        private void picbackhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenú formMenú = new FormMenú();
            formMenú.Show();
        }

        private void FormActivo_Inactivo_Closing(object sender, FormClosingEventArgs e)
        {
            FormActivo_Inactivo formActivo_Inactivo = new FormActivo_Inactivo();
            formActivo_Inactivo.Close();
            Application.Exit();
        }
    }
}
