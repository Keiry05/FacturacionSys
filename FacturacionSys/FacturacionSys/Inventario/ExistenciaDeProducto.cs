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
    public partial class ExistenciaDeProducto : Form
    {
        public ExistenciaDeProducto()
        {
            InitializeComponent();
        }

        private void ExistenciaDeProducto_Load(object sender, EventArgs e)
        {
            ProductoC existencia = new ProductoC();
            dbExistencia.DataSource = existencia.BuscarExistencia();

        }
    }
}
