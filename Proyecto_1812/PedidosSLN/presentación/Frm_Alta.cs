
using RecetasSLN.datos.DTOs;
using RecetasSLN.datos.interfaz;
using RecetasSLN.datos.Servicio;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSLN.Presentacion
{
    public partial class Frm_Alta : Form
    {

        private ProyectoDTO oProyecto;
        public Frm_Alta()
        {
            InitializeComponent();
            oProyecto = new ProyectoDTO();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void Frm_Alta_Presupuesto_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            cboPersonal.Items.Clear();

            List<Empleado> LstEmpleados = ServicioDao.ObtenerInstancia().GetEmpleados();


            foreach (Empleado empleado in LstEmpleados)
            {
                cboPersonal.Items.Add(empleado);
            }

            cboPersonal.SelectedIndex= 0;
            cboPersonal.DropDownStyle= ComboBoxStyle.DropDownList;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["PERSONAL"].Value.ToString() == cboPersonal.Text)
                {
                    MessageBox.Show("No se pueden repetir los empleados");
                    cboPersonal.Focus();
                }
            }

            //validar los datos
            if (ValidarDatos())
            {
                Empleado empleado = (Empleado)cboPersonal.SelectedItem;

                if (!ExistePersonal(empleado.Nombre))
                {
                    DetallePersonalDTO detalle = new DetallePersonalDTO();

                    detalle.Empleado = empleado;

                    detalle.horas = Convert.ToInt32(nudCantidad.Value);

                    oProyecto.CargarDetalle(detalle);

                    dgvDetalles.Rows.Add(new object[]
                     {
                    0,
                    empleado.Nombre,
                    detalle.horas,
                    "Quitar"
                     });

                }

                

            }
          
        }

       private bool ExistePersonal(string text)
        {
            bool aux = false;

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["PERSONAL"].Value.Equals(text))
                {
                    aux= true;
                    MessageBox.Show("Este Empleado ya esta cargado");
                }
            }

            return aux;
         
           
        }



        private bool ValidarDatos()
        {
            bool aux = true;

            if (dtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la de hoy");
                aux = false;
                dtpFecha.Focus();

                return aux;
            }
            if (txtResp.Text == string.Empty)
            {
                MessageBox.Show("Seleccionar descripcion");
                aux = false;
                txtResp.Focus();
                return aux;
            }
            return aux;
        }










        //private void CargarDetalle(Empleado empleado)
        //{

        //}

        //private void ActualizarDgv()
        //{



        //}







        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cboPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
