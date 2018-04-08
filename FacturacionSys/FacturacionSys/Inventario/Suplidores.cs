using FacturacionSysDLL.BUSINESS_LAWYER;
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
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
        }


        //Nota; dice que el boton se llama cliente en aqui, pero en el name de propiedades esta como nuevo suplidor no entiendo porque no se guarda.
        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            var Nsuplidor = new NuevoSuplidor();
            Nsuplidor.ShowDialog();

        }

        private void Suplidores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuplidorC suplidor = new SuplidorC ();

            dataGridSuplidor.DataSource = suplidor.buscarListadoSuplidor(txtcedula.Text, textdescripcion.Text);
          
        }

        private void dataGridSuplidor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int suplidor = Convert.ToInt32(this.dataGridSuplidor.Rows[e.RowIndex].Cells["Codigo"].Value);
                var nuevoSupli = new NuevoSuplidor();
                nuevoSupli.Editar(suplidor);
            }
        }
    }
}
