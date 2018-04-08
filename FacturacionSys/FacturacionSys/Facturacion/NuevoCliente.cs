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
    public partial class NuevoCliente : Form
    {
        public int CodCliente { get; set; }
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
            FacturacionSysDLL.DATA.TBL_Cliente cliente = new FacturacionSysDLL.DATA.TBL_Cliente();
            var clienteModel = new ClienteC();
              
            cliente.Nombres = txtNombres.Text;
            cliente.Apellidos = txtApellidos.Text;
            cliente.NumIdentif = txtCedula.Text;
            cliente.Telefono1 = txtTelefono1.Text;
            cliente.Telefono2 = txtTelefono2.Text;
            cliente.Email = txtEmail.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Estatus = 1;
            cliente.Descripcion = txtNombres.Text + " " + txtApellidos.Text;
            cliente.CodCliente = this.CodCliente;
            clienteModel.Guardar(cliente);
            MessageBox.Show("Guardado satisfactoriamente");
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
              
        }

        public void Editar(int id)
        {
            ClienteC cliente = new ClienteC();
            var result = cliente.BuscarPorID(id);
            txtNombres.Text = result.Nombres;
            txtApellidos.Text = result.Apellidos;
            txtCedula.Text = result.NumIdentif;
            txtDireccion.Text = result.Direccion;
            txtEmail.Text = result.Email;
            txtTelefono1.Text = result.Telefono1;
            txtTelefono2.Text = result.Telefono2;
            this.CodCliente = id;
            this.ShowDialog();
                
        }

    }
}
