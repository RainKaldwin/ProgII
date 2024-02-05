using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public  class Empleado
    {
        public  int Legajo { get; set; }
        public string Nombre { get; set; }
        public string  Rol { get; set; }

        public Empleado()
        {
            
        }

        public Empleado(int legajo,string nombre,string rol)
        {
            Legajo = legajo;
            Nombre = nombre;
            Rol = rol;
        }

        public override string ToString()
        {
            return Legajo + "," + Nombre;
        }



    }
}
