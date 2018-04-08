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
    public partial class Realizar_Pedido : Form
    {
        public Realizar_Pedido()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var products = new BuscarProductos();
            products.ShowDialog();
            var Product = new ProductoC();
            var producto = Product.BuscarListadoProductos(products.referencia, "").FirstOrDefault();

            txtCodigoD.Text = producto.Referencia;
            txtDescripcionD.Text = producto.Descripcion;
            nudCantidad.Value = 1;
            nudPrecioD.Value = producto.Precio.Value;
            txtImporte.Text = (producto.Precio.Value *1).ToString();

        }


      
    }
}
