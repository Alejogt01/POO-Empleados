using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosPOO
{
    public partial class FormPermanente : Form
    {
        public FormPermanente()
        {
            InitializeComponent();
        }

        private void FormPermanente_Load(object sender, EventArgs e)
        {

        }

        private void FormPermanente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenú formMenú = new FormMenú();
            formMenú.Close();
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void picbackhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenú formMenú = new FormMenú();
            formMenú.Show();
        }

        private bool ValidacionesVacías()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtpuesto.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtsalario.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtusuario.Text.Trim()))
            {
                MessageBox.Show("POR FAVOR COMPLETA TODOS LOS CAMPOS.");
                return false;
            }

            return true;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionesVacías())
                return;

            decimal salario;
            if (!decimal.TryParse(txtsalario.Text.Trim(), out salario))
            {
                MessageBox.Show("INGRESA SOLO NÚMEROS EN EL SALARIO.");
                return;
            }

            EmpleadoPermanente empleadoPermanente = new EmpleadoPermanente
            {
                Nombre = txtnombre.Text.Trim(),
                Puesto = txtpuesto.Text.Trim(),
                Salario = salario,
                Usuario = txtusuario.Text.Trim(),
            };

            GestiónEmpleados.AgregarEmpleado(empleadoPermanente);
            MessageBox.Show("EL EMPLEADO SE GUARDÓ CON ÉXITO.");

            txtnombre.Clear();
            txtpuesto.Clear();
            txtsalario.Clear();
            txtusuario.Clear();

        }
    }
}
