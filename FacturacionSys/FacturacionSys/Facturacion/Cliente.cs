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
    
    public partial class Cliente : Form
    {
       
        public Cliente()
        {
            InitializeComponent();
         
        }
        

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            var Ncliente = new NuevoCliente();
            Ncliente.ShowDialog();
        }

        
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ClienteC cliente = new ClienteC();

            dataGridClientes.DataSource = cliente.BuscarListadoClientes(txtCedulaB.Text, txtDescripcionB.Text);
          
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cliente = Convert.ToInt32(this.dataGridClientes.Rows[e.RowIndex].Cells["Codigo"].Value);
            var nuevoCl = new NuevoCliente();
            nuevoCl.Editar(cliente);
        }
    }
}
