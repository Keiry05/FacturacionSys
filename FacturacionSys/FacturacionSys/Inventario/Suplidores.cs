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
            ClienteC suplidor = new ClienteC();

            dataGridClientes.DataSource = cliente.BuscarListadoClientes(txtCedulaB.Text, txtDescripcionB.Text);
        }
    }
}
