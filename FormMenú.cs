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
    public partial class FormMenú : Form
    {
        public FormMenú()
        {
            InitializeComponent();
        }

        private void picpermanente_Click(object sender, EventArgs e)
        {
            FormPermanente formPermanente = new FormPermanente();
            formPermanente.Show();
            this.Hide();
        }
        private void picsalir_Click(object sender, EventArgs e)
        {
            FormMenú formMenú = new FormMenú();
            formMenú.Close();
            Application.Exit();
        }

        private void FormMenú_Load(object sender, EventArgs e)
        {

        }

        private void FormMenú_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenú formMenú = new FormMenú();
            formMenú.Close();
            Application.Exit();
        }

        private void piccontratado_Click(object sender, EventArgs e)
        {
            FormContratado formContratado = new FormContratado();
            formContratado.Show();
            this.Hide();
        }

        private void picbuscarempleado_Click(object sender, EventArgs e)
        {
            FormBuscarPorNombre formBuscarPorNombre = new FormBuscarPorNombre();
            formBuscarPorNombre.Show();
            this.Hide();

        }

        private void picmostrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormActivo_Inactivo formActivo_Inactivo = new FormActivo_Inactivo();
            formActivo_Inactivo.Show();
        }
    }
}
