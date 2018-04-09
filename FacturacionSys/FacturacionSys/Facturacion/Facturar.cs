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
    public partial class Facturar : Form
    {
        public Facturar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            Pedido entradas = new Pedido();
            dgFacturas.DataSource = entradas.BuscarListadoPedidosPendiente();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int factura =Convert.ToInt32(this.dgFacturas.Rows[e.RowIndex].Cells["Codigo"].Value);
            var nuevoFact = new Realizar_Factura();
            nuevoFact.Editar(factura);
        }
    }
}
