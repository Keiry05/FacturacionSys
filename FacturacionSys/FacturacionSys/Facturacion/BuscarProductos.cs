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
    public partial class BuscarProductos : Form
    {

        public string referencia { get; set; }


        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var CreaProdi = new Nuevo_Producto();
            CreaProdi.ShowDialog();
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Product = new ProductoC();
        
            dataGridProductos.DataSource = Product.BuscarListadoProductos(txtReferenciaB.Text, txtDescripcionB.Text);
           
        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var RealizarPedido = new Realizar_Pedido();
            RealizarPedido.txtCodigoD.Text = dataGridProductos.Rows[e.RowIndex].Cells["Referencia"].Value.ToString();
            RealizarPedido.txtDescripcionD.Text = dataGridProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            RealizarPedido.nudPrecioD.Value = Convert.ToDecimal(dataGridProductos.Rows[e.RowIndex].Cells["Precio"].Value);
            RealizarPedido.nudCantidad.Value = 1;
            RealizarPedido.Show();
       
        }



    }
    }
