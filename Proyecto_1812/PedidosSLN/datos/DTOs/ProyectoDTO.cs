using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos.DTOs
{
    public class ProyectoDTO
    {
        public DateTime fechaInicio { get; set; }
        public string descripcion { get; set; }
        public int totalHrs { get; set; }
        public int codigo { get; set; }
        public List<DetallePersonalDTO> Detalle { get; set; }

        public ProyectoDTO()
        {
            Detalle = new List<DetallePersonalDTO>();
        }



        public void CargarDetalle(DetallePersonalDTO detalle)
        {
            Detalle.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
          Detalle.RemoveAt(indice);
        }

        public int TotalHoras()
        {
            int acumulador = 0;
            foreach (DetallePersonalDTO detalle in Detalle)
            {
               
              acumulador+= detalle.horas;
            }

            return acumulador;

        }

    }
}
