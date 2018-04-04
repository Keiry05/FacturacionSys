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
    public partial class OrdenDeCompra : Form
    {
        public OrdenDeCompra()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearSuplidor_Click(object sender, EventArgs e)
        {
            var NuevaO = new NuevaOrdenDeCompra();
            NuevaO.ShowDialog();
        }
    }
}
