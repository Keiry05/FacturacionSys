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

namespace FacturacionSys.Inventario
{
    public partial class BuscarProductosIn : Form
    {
        public BuscarProductosIn()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var Product = new ProductoC();

            dataGridProductos.DataSource = Product.BuscarListadoProductos(txtReferenciaB.Text, txtDescripcionB.Text);

        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var EntradaInv = new Entrada_Inventario();
            EntradaInv.txtCodigoD.Text = dataGridProductos.Rows[e.RowIndex].Cells["Referencia"].Value.ToString();
            EntradaInv.txtDescripcionD.Text = dataGridProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
           
            EntradaInv.nudCantidad.Value = 1;
            EntradaInv.Show();

        }
    }
}
