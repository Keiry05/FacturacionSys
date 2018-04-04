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

        private void btnCrearSuplidor_Click(object sender, EventArgs e)
        {
            var AgregarP = new Agregar_Producto();
            AgregarP.ShowDialog();
        }
    }
}
