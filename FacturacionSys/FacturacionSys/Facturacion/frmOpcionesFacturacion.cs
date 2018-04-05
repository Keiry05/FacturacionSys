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
    public partial class frmOpcionesFacturacion : Form
    {
        public frmOpcionesFacturacion()
        {
            InitializeComponent();
        }

        private void OpcionesFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             var cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void realizarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var factura = new Realizar_Factura();
            factura.ShowDialog();
        }

        private void realizarDevoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var devolucion = new FormDevolucion();
            devolucion.ShowDialog();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedi = new Realizar_Pedido();
            pedi.ShowDialog();
        }

        private void reportesAsociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pendi = new Pedidos_pendientes();
            pendi.ShowDialog();
        }

        private void pedidosFacturadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var factu = new PedidosFacturados();
            factu.ShowDialog();
        }

        private void realizarNotaDeCrèditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var credito = new FormNotasCredito();
            credito.ShowDialog();
        }
        
    }
}
