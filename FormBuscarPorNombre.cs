using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmpleadosPOO
{
    public partial class FormBuscarPorNombre : Form
    {
        public FormBuscarPorNombre()
        {
            InitializeComponent();
            this.FormClosing += FormBuscarPorNombre_FormClosing;
        }

        private void FormBuscarPorNombre_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBuscarPorNombre formBuscarPorNombre = new FormBuscarPorNombre();
            formBuscarPorNombre.Close();
            Application.Exit();
        }

        private void picbackhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenú formMenú = new FormMenú();
            formMenú.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtbuscar.Text.Trim();

            var empleadosencontrados = GestiónEmpleados.ObtenerEmpleados()
                .Where(emp => emp.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (empleadosencontrados.Any())
            {
                var mostrarDatos = empleadosencontrados.Select(emp => new
                {
                    Nombre = emp.Nombre,
                    Puesto = emp.Puesto,
                    Salario = emp.Salario,
                    Usuario = emp.Usuario,
                    Tipo_Contrato = (emp is EmpleadoContratado contratado)
                        ? contratado.TipoContrato
                        : "Permanente"
                }).ToList();

                dgvmostrarbusqueda.DataSource = null;
                dgvmostrarbusqueda.AutoGenerateColumns = true;
                dgvmostrarbusqueda.DataSource = mostrarDatos;
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRARON EMPLEADOS.");
                dgvmostrarbusqueda.DataSource = null;
            }
        }

        private void FormBuscarPorNombre_Load(object sender, EventArgs e)
        {

        }

        private void dgvmostrarbusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


