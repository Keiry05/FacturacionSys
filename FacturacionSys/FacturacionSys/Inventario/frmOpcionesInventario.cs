using FacturacionSys.Facturacion;
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
    public partial class frmOpcionesInventario : Form
    {
        public frmOpcionesInventario()
        {
            InitializeComponent();
        }

        private void frmOpcionesInventario_Load(object sender, EventArgs e)
        {

        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var suplidor = new Suplidores();
            suplidor.ShowDialog();
        }

        private void realizarEntradaAlInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var EntradaInv = new Entrada_Inventario();
            EntradaInv.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pro = new BuscarProductos();
            pro.ShowDialog();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void existenciaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Exi = new ExistenciaDeProducto();
            Exi.ShowDialog();
        }

        private void entradasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entra = new EntradaDeProducto();
            entra.ShowDialog();
        }

        private void salidasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sali = new SalidaDeProducto();
            sali.ShowDialog();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void realizarConduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
