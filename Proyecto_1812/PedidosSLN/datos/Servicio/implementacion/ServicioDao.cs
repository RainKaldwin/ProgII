using RecetasSLN.datos.DAO;
using RecetasSLN.datos.DTOs;
using RecetasSLN.datos.interfaz;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.Servicio
{
    public class ServicioDao : IServicioDao
    {
        private static ServicioDao instancia;


        private IEmpleadoDao empleadoDao;

        private IProyectoDao proyectoDao;


        private ServicioDao()
        {
            empleadoDao = new EmpleadoDao();
            proyectoDao = new ProyectoDao();
        }

        public  static ServicioDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ServicioDao();
            }
            return instancia;
        }



        //Empleado
        public List<Empleado> GetEmpleados()
        {
            return empleadoDao.GetEmpleados();
        }

        //proyecto  
        public bool insertarProyecto(ProyectoDTO proyecto)
        {
            return proyectoDao.InsertarProyecto(proyecto);
        }

    }
}
