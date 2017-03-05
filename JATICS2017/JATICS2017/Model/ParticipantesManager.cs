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
    class ParticipantesManager
    {
        /// <summary>
        /// FUNCION QUE REALIZA LA BUSQUEDA DE LOS REGISTROS POR EL NOMBRE O
        /// ENLISTA EL CONTENIDO DE LA TABLA
        /// </summary>
        /// <param name="Valor"></param>
        /// <returns></returns>
        public static List<Participante> getAll(Boolean status,String Valor = "")
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Participantes.Where(r => r.bStatus == status &&
                    r.sApellidos.Contains(Valor)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// FUNCION QUE GUARDA NUEVO REGISTRO
        ///     O ACTUALIZA LOS DATOS DEL MISMO
        /// </summary>
        /// <param name="nParticipantes"></param>
        public static void SaveOrUpdate(Participante nParticipantes)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nParticipantes.pkMatricula > 0)
                    {
                        ctx.Entry(nParticipantes).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nParticipantes).State = System.Data.Entity.EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// FUNCION QUE REALIZA LA BUSQUEDA DEL REGISTRO POR DU PK
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static Participante getBYId(int Id)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Participantes.Where(r => r.pkMatricula == Id).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// FUNCION PARA BORADO LOGICO DEL PARTICIPANTE
        /// </summary>
        /// <param name="pkParticipante"></param>
        public static void Delete(int pkParticipante)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    Participante participante = getBYId(pkParticipante);
                    if (participante != null)
                    {
                        participante.bStatus = false;
                        ctx.Entry(participante).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
