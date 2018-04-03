using FacturacionSys.Facturacion;
using FacturacionSys.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionSys.Menu
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnModInventario_Click(object sender, EventArgs e)
        {
            var inventario = new frmOpcionesInventario();
            inventario.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnModFacturacion_Click(object sender, EventArgs e)
        {
            var facturacion = new frmOpcionesFacturacion();
            facturacion.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
