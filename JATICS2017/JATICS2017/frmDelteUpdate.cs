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
/// </summary>

namespace JATICS2017
{
    public partial class frmDelteUpdate : Form
    {
        frmMain mVentan;
        String Matricula;
        TipoAccion AccionRealizar;
        Participante objParticipante;
        public frmDelteUpdate(frmMain ventana, String matricula, TipoAccion accion)
        {
            InitializeComponent();
            this.mVentan = ventana;
            this.Matricula = matricula;
            AccionRealizar = accion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //SE VALIDA SI EL USUARIO REALMENTE QUIERE CANCELAR EL PROCESO DE REGISTRO
            if (MessageBox.Show("Quieres cancelar el Proceso de registro", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDelteUpdate_Load(object sender, EventArgs e)
        {//BUSCAMOS EL PARTICIPANTE SEGUN LA MATRICULA PROPORCIONADA EN EL CONSTRUCTOR
            objParticipante = ParticipantesManager.getBYId(Convert.ToInt32(this.Matricula));

            //MOSTRAMOS LA INFORMACION DEL PARTICIPANTE EN EL FORMULARIO
            MostrarDatos();
        }


        private void MostrarDatos()
        {
            if (objParticipante != null)
            {
                txtNombre.Text = objParticipante.sNombre;
                txtApellidos.Text = objParticipante.sApellidos;
                txtEmail.Text = objParticipante.sEmail;
                txtMatricula.Text = objParticipante.pkMatricula.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (AccionRealizar == TipoAccion.ACTUALIZACION)
            {
                //LLENAMOS EL OBJETO CON LOS DATOS EN EL FORMULARIO
                objParticipante.sNombre = txtNombre.Text;
                objParticipante.sApellidos = txtApellidos.Text;
                objParticipante.sEmail = txtEmail.Text;
                //SE LLAMA LA FUNCION PARA GUARDAR LOS CAMBIOS
                ParticipantesManager.SaveOrUpdate(objParticipante);
                //SE ACTUALIZA LA VENTANA PRINCIPAL
                this.mVentan.MostrarDatos();
            }
            else
            {
                //VALIDAS QUE REALMENTE SE QUIERE BORRAR EL REGISTRO
                if (MessageBox.Show("Realmente decea borra el registro", "Borrado de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ParticipantesManager.Delete(objParticipante.pkMatricula);
                }
            }
            //CIERRA LA VENTANA 
            this.Close();

        }
    }

    //ENUMERACION PARA QUE LA VENTANA TRABAJE COMO UPDATE / DELETE 
    public enum TipoAccion
    {
        ACTUALIZACION,
        BORRADO
    }
}
