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
using BDDCLOUD.datos;


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

        private void btnConsultarPlatVidJu (object sender, EventArgs e)
        {
            prcConsultarAllPlataformasVideoJuegoTableAdapter prc = new prcConsultarAllPlataformasVideoJuegoTableAdapter();
            dsVideoJuegos.prcConsultarAllPlataformasVideoJuegoDataTable dt = prc.GetData();
            dgvPVJ.DataSource = dt;

            
        }

        private void btnInsertarPVJ_Click(object sender, EventArgs e)
        {
            prcConsultarAllPlataformasVideoJuegoTableAdapter prc = new prcConsultarAllPlataformasVideoJuegoTableAdapter();
            int varIDVJ = -1;
            int varIDP = -1;
            try
            {
                varIDVJ = int.Parse(txtbVJID.Text);
                varIDP = int.Parse(txtbPID.Text);
                prc.Insert(varIDVJ,varIDP);
                MessageBox.Show("Se completó exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo completar con los datos ingresados", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            
        }

        private void btnActualizarPVJ_Click(object sender, EventArgs e)
        {
            prcConsultarAllPlataformasVideoJuegoTableAdapter prc = new prcConsultarAllPlataformasVideoJuegoTableAdapter();
            int varIDVJ = -1;
            int varIDP = -1;
            int varNIDP = -1;
            try
            {
                varIDVJ = int.Parse(txtbVJID.Text);
                varIDP = int.Parse(txtbPID.Text);
                varNIDP = int.Parse(txtbNPID.Text);
                prc.Update(varIDVJ, varIDP, varNIDP);
                MessageBox.Show("Se completó exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo completar con los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPVJ_Click(object sender, EventArgs e)
        {
            prcConsultarAllPlataformasVideoJuegoTableAdapter prc = new prcConsultarAllPlataformasVideoJuegoTableAdapter();
            int varIDVJ = -1;
            int varIDP = -1;
            try
            {
                varIDVJ = int.Parse(txtbVJID.Text);
                varIDP = int.Parse(txtbPID.Text);
                prc.Delete(varIDVJ, varIDP);
                MessageBox.Show("Se completó exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo completar con los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
