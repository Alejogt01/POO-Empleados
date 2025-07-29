using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosPOO
{
    public partial class FormContratado : Form
    {
        public FormContratado()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormContratado_Load(object sender, EventArgs e)
        {

        }

        private void FormContratado_Closing(object sender, FormClosingEventArgs e)
        {
            FormContratado formContratado = new FormContratado();
            formContratado.Close();
            Application.Exit();
        }

        private void picbackhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenú formMenú = new FormMenú();
            formMenú.Show();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtpuesto.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtsalario.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtusuario.Text.Trim()) ||
                cmbDuracionContrato.SelectedItem == null ||
                cmbTipoContrato.SelectedItem == null)
            {
                MessageBox.Show("POR FAVOR COMPLETA TODOS LOS CAMPOS.");
                return;
            }

            if (!decimal.TryParse(txtsalario.Text.Trim(), out decimal salario))
            {
                MessageBox.Show("POR FAVOR INGRESA UN SALARIO VÁLIDO.");
                return;
            }

            string nombre = txtnombre.Text.Trim();
            string puesto = txtpuesto.Text.Trim();
            string usuario = txtusuario.Text.Trim();
            string duracioncontrato = cmbDuracionContrato.SelectedItem.ToString();
            string tipocontrato = cmbTipoContrato.SelectedItem.ToString();

            EmpleadoContratado Empleadocontratado = new EmpleadoContratado()
            {
                Nombre = nombre,
                Puesto = puesto,
                Salario = salario,
                Usuario = usuario,
                DuracionContrato = duracioncontrato,
                TipoContrato = tipocontrato,
            };

            GestiónEmpleados.AgregarEmpleado(Empleadocontratado);
            MessageBox.Show("EL EMPLEADO SE GUARDÓ CON ÉXITO.");

            txtnombre.Clear();
            txtpuesto.Clear();
            txtsalario.Clear();
            txtusuario.Clear();
            cmbDuracionContrato.SelectedIndex = -1;
            cmbTipoContrato.SelectedIndex = -1;
            dtpFechaInicio.ResetText();
            dtpFechaFin.ResetText();

        }
    }
}
