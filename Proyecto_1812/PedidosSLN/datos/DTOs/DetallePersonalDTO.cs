using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.DTOs
{
    public class DetallePersonalDTO
    {
        public int horas { get; set; }

        public Empleado Empleado{ get; set; }


    }
}
