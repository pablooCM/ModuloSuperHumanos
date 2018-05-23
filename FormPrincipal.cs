using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSuperHumanos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void buttonSuperHumano_Click(object sender, EventArgs e)
        {
            FormSuperHumano nuevaVentana = new FormSuperHumano();
            nuevaVentana.Show();

        }

        private void buttonGestionEquipos_Click(object sender, EventArgs e)
        {
            FormGestionEquipos nuevaVenta = new FormGestionEquipos();
            nuevaVenta.Show();
        }

        private void buttonGestionPoderes_Click(object sender, EventArgs e)
        {
            FormPoderes nuevaVentana = new FormPoderes();
            nuevaVentana.Show();
        }

        private void buttonGestionVacaciones_Click(object sender, EventArgs e)
        {
            FormGestionVacaciones nuevaVentana = new FormGestionVacaciones();
            nuevaVentana.Show();

        }

        private void buttonGestionMetodoPago_Click(object sender, EventArgs e)
        {
            FormMetodosPago nuevaVen = new FormMetodosPago();
            nuevaVen.Show();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            FormReportes nuevaV = new FormReportes();
            nuevaV.Show();
        }
    }
}
