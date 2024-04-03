using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces.Entidad;
using Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Implementacion
{
    public class EntidadRepo : IEntidadRepo
    {
        readonly InventariosContext ctx;
        public int ActualizarEntidad(EntidadDTO entidad)
        {
            try
            {
                Entidad EntidadEditada = ctx.Entidads
                                            .Where( e => e.Identidad == entidad.Identidad)
                                            .First();

                EntidadEditada.Idtipodocumento = entidad.Idtipodocumento;
                EntidadEditada.NumeroDocumento = entidad.NumeroDocumento;
                EntidadEditada.RazonSocial = entidad.RazonSocial;
                EntidadEditada.LogUsuarioModificacion = entidad.LogUsuarioModificacion;
                EntidadEditada.LogFechaModificacion = DateTime.Now ;

                ctx.SaveChanges();

                return entidad.Identidad;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DesactivarEntidad(int identidad)
        {
            throw new NotImplementedException();
        }

        public int GuardarEntidad(EntidadDTO entidad)
        {
            throw new NotImplementedException();
        }

        public EntidadDTO ObtenerEntidadporDocumento(string documento)
        {
            throw new NotImplementedException();
        }

        public EntidadDTO ObtenerEntidadporId(int identidad)
        {
            throw new NotImplementedException();
        }
    }
}
