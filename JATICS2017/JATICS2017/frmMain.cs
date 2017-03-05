using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JATICS2017.Model;
/// <summary>
/// PROYECTO DISEÑADO Y DESARROLADO POR:
///     MTI. Noe Cazarez Camargo
///     nacazarez@uthermosillo.edu.mx
///     
/// FECHA: 01/03/2017
/// JATICS 2017  EN UTPP 
/// PUERTO PEÑASCO
/// 
/// PARA CREAR LA BASE DE DATOS DEBEN ABRIR LA CONSOLA DE ADMINISTRACION DE PAQUETES Y EJECUTAR EL COMANDO
/// upodate-database
/// </summary>s

namespace JATICS2017
{
    public partial class frmMain : Form
    {
       

        /// <summary>
        /// FUNCION RESPONSABLE DE LLENAR LA CUADRICULA SEGUN  LO ESCRITO EN EL CUANDRO DE TEXTO Y 
        /// EL ESTATUS SELECCIONADO EN EL CONTROL CHECKED
        /// </summary>
        public void MostrarDatos()
        {
            this.grdDatos.DataSource = ParticipantesManager.getAll(this.chkStatus.Checked, txtFiltro.Text);
        }

        public frmMain()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void grdDatos_DataSourceChanged(object sender, EventArgs e)
        {
            //MOSTARMOS EL NUMERO DE REGISTROS MOSTRADOS EN LA CUADRICULA, CUANDO CAMBIE LA FUENTE DE DATOS
            lblTotalRegistros.Text = "Total de Registros: " + grdDatos.Rows.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //INTANCIAMOS LA VENTANA DE REGISTRO
            frmAddParticipante nVentana = new frmAddParticipante(this);
            //SE MUESTAR COMO DIALOGO
            nVentana.ShowDialog();
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String valor = grdDatos[0, e.RowIndex].Value.ToString();
            frmDelteUpdate nVentan = new frmDelteUpdate(this, valor, TipoAccion.ACTUALIZACION);
            nVentan.ShowDialog();
        }
    }
}
