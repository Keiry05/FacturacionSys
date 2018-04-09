using FacturacionSys.Facturacion;
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
    public partial class Entrada_Inventario : Form
    {
        public Entrada_Inventario()
        {
            InitializeComponent();
        }
        ProductoC producto = new ProductoC();

        private void btnCrearSuplidor_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductosIn products = new BuscarProductosIn();
            products.ShowDialog();

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }

        public void calcularImporte()
        {
            var valor = nudCantidad.Value * nupPrecio.Value;

            this.NupImporte.Value = valor;
            this.Show();
        }

        private void nupPrecio_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var codigoProducto = producto.BuscarCodigo(txtCodigoD.Text);
            dataGridProductos.Rows.Add(codigoProducto, txtCodigoD.Text, txtDescripcionD.Text, nudCantidad.Value,nupPrecio.Value, NupImporte.Value);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Entrada_Inventario_Load(object sender, EventArgs e)
        {

        }


        private void LlenarCboClientes()
        {
            var suplidor = new Suplidor();
            cboSuplidor.DisplayMember = "Nombres";
            cboSuplidor.ValueMember = "Codigo";
            cboSuplidor.DataSource = clientes.BuscarListadoClientes("", "");

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
            dtpFechaCompromiso.Format = DateTimePickerFormat.Custom;
            dtpFechaCompromiso.CustomFormat = "yyyy-MM-dd";
        }
    }
}
