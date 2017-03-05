using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

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
    class DataModel:DbContext
    {
        public DbSet<Participante> Participantes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
