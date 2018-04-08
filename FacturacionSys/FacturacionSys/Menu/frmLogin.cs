
using FacturacionSys.Inventario;
using FacturacionSys.Menu;
using FacturacionSysDLL.BUSINESS_LAWYER.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FacturacionSys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

            var login = new LoginC();
            if (login.Logguear(txtUsuario.Text, txtContrasena.Text)) {
                this.Hide();
                var inicio = new frmInicio();
                inicio.ShowDialog();
            }
            else
            {
                throw new Exception("Usuario o contraseña incorrecta");
            }
        }
          catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
