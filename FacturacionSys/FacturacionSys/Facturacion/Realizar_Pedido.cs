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

        private void Realizar_Pedido_Load(object sender, EventArgs e)
        {
            LlenarCboClientes();
        }


        private void LlenarCboClientes()
        {
            var clientes = new ClienteC();
            cboCliente.DisplayMember = "Nombres";
            cboCliente.ValueMember = "Codigo";
            cboCliente.DataSource = clientes.BuscarListadoClientes("", "");
          
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    
        BuscarProductos products = new BuscarProductos();
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
           
            products.ShowDialog();
            products.Hide();
        }
    }
}
