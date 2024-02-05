using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
   public class Proyecto
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
       public   string Descripcion { get; set; }
        public  int TotalHrs { get; set; }

        public List<DetallePersonal> DetallePersonal{ get; set; }

        public Proyecto()
        {
            
        }

        public Proyecto(int codigo,DateTime fecha, string descripcion,int totalHoras,List<DetallePersonal> detalle)
        {
            Codigo = codigo;
            Fecha = fecha;
            Descripcion = descripcion;
            TotalHrs = totalHoras;
            DetallePersonal = detalle;
            
        }

        public override string ToString()
        {
            return Descripcion;
        }





    }
}
