using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// PROYECTO DISEÑADO Y DESARROLADO POR:
///     MTI. Noe Cazarez Camargo
///     nacazarez@uthermosillo.edu.mx
///     
/// FECHA: 01/03/2017
/// JATICS 2017  EN UTPP 
/// PUERTO PEÑASCO
/// </summary>
using JATICS2017.Model;

namespace JATICS2017
{
    public partial class frmAddParticipante : Form
    {
        public frmMain mVentana;
        public frmAddParticipante(frmMain Ventana)
        {
            InitializeComponent();
            this.mVentana = Ventana;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {//SE VALIDA SI EL USUARIO REALMENTE QUIERE CANCELAR EL PROCESO DE REGISTRO
            if (MessageBox.Show("Quieres cancelar el Proceso de registro", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //CREAMOS LA INTANCIA DEL PARTICIPANTE Y SE LLENA CON LOS DATOS INGRESADOS
            Participante nParticipante = new Participante();
            nParticipante.sNombre = txtNombre.Text;
            nParticipante.sApellidos = txtApellidos.Text;
            nParticipante.sEmail = txtEmail.Text;

            //SE MANDA LLAMAR LA FUNCION GUARDAR
            ParticipantesManager.SaveOrUpdate(nParticipante);
            //ACTUALIZA LA VENTANA PRINCIPAL
            mVentana.MostrarDatos();
            //SE CIERRA LA VENTANA
            this.Close();

        }
    }
}
