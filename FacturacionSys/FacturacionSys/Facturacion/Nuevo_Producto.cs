using FacturacionSysDLL.BUSINESS_LAWYER.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionSys.Facturacion
{
    public partial class Nuevo_Producto : Form
    {
        public int CodProducto { get; set; }
        public Nuevo_Producto()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                FacturacionSysDLL.DATA.TBL_Producto producto = new FacturacionSysDLL.DATA.TBL_Producto();
                var ProductoModel = new ProductoC();

                producto.Descripcion = txtDescripcion.Text;
                producto.Referencia = txtreferencia.Text;
                producto.Precio = precio.Value;
                producto.Costo = costo.Value;
                producto.Estatus = 1;
                producto.FecInclusion = FechaInclucion.Value;
                producto.FecModificacion = fechamodificacion.Value;
                producto.CodProducto = this.CodProducto;
                ProductoModel.Guardar(producto);
                MessageBox.Show("Guardado satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Editar(int id)
        {
            ProductoC producto = new ProductoC();
            var result = producto.BuscarPorID(id);
            txtDescripcion.Text= result.Descripcion;
            txtreferencia.Text=result.Referencia;
            //precio.Value= result.Precio;
            //costo.Value=result.Costo;
           
           this.CodProducto = id;
            this.ShowDialog();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


    
