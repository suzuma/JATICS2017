using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// PROYECTO DISEÑADO Y DESARROLADO POR:
///     MTI. Noe Cazarez Camargo
///     nacazarez@uthermosillo.edu.mx
///     
/// FECHA: 01/03/2017
/// JATICS 2017  EN UTPP 
/// PUERTO PEÑASCO
/// </summary>


namespace JATICS2017.Model
{
    [Table(name:"Participantes")]
   public class Participante
    {
        [Key]
        public int pkMatricula { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public String sNombre { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public String sApellidos { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public String sEmail { get; set; }
        
        public String sTelefono { get; set; }

        public Boolean bStatus { get; set; }
        public Participante() {
            this.bStatus = true;
        }
    }
}
