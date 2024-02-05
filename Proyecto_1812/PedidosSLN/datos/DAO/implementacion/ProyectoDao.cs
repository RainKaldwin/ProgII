using ExamenSLN.datos;
using RecetasSLN.datos.DTOs;
using RecetasSLN.datos.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.DAO
{
    public class ProyectoDao : IProyectoDao
    {
        public bool InsertarProyecto(ProyectoDTO proyecto)
        {
            bool resultado = false;

            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@fecha_inicio", proyecto.fechaInicio),
                new Parametro("@descripcion", proyecto.descripcion),
                new Parametro("@total_hrs", proyecto.totalHrs)
            };

            int nro_proyecto = HelperDB.ObtenerInstancia().InsertarSql("SP_INSERTAR_PROYECTO", parametros, "@codigo");

            if (nro_proyecto > 0)
            {
                int aux = 0;

                int detallenro = 1;

                proyecto.codigo = nro_proyecto;

                if (proyecto.Detalle != null)
                {
                    foreach (DetallePersonalDTO detalle in proyecto.Detalle)
                    {
                        List<Parametro> lstDet = new List<Parametro>()
                            {
                                new Parametro("@codigo", proyecto.codigo),
                                new Parametro("@detalle_nro", detallenro),
                                new Parametro("@legajo", detalle.Empleado.Legajo),
                                new Parametro("@horas", detalle.horas)
                         };

                        aux += HelperDB.ObtenerInstancia().InsertarSql("SP_INSERTAR_DETALLES", lstDet, "");
                        detallenro++;
                    }
                }

                if (aux == proyecto.Detalle.Count)
                {
                    resultado = true;
                }
            }

            return resultado;


        }


    }
}
    

