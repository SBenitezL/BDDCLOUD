using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDDCLOUD.datos.dsVideoJuegosTableAdapters;

namespace BDDCLOUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdJugador.Text);

                prcJuegosJugadosTableAdapter prc = new prcJuegosJugadosTableAdapter();
                datos.dsVideoJuegos.prcJuegosJugadosDataTable dt = prc.GetData(id);
                dgvJugador.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("La id ingresado no es valido");
            }
            txtIdJugador.Clear();
        }

        private void btnConsultarAnio_Click(object sender, EventArgs e)
        {
            try
            {
                int anio = int.Parse(txtAnio.Text);
                consultarPosterioresTableAdapter prc = new consultarPosterioresTableAdapter();
                datos.dsVideoJuegos.consultarPosterioresDataTable dt = prc.GetData(anio);
                dgvJugador.DataSource = dt;
            }
            catch 
            {
                MessageBox.Show("El año ingresado no es valido");
            }
            txtAnio.Clear();
        }
    }
}
