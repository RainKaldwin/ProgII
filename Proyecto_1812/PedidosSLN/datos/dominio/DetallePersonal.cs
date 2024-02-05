using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class DetallePersonal
    {

        public int Codigo { get; set; }
        public int  DetalleNro { get; set; }
        public Empleado Empleado { get; set; }

        public int Horas { get; set; }

        public DetallePersonal()
        {
            
        }

        public DetallePersonal(int codigo,int detalleNro,Empleado empleado, int horas)
        {
            Codigo = codigo;
            DetalleNro = detalleNro;
            Empleado = empleado;
            Horas = horas;  
        }
    }
}
