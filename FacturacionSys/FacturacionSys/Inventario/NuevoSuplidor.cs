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
    public partial class NuevoSuplidor : Form
    {
        public int CodSuplidor { get; set; }
        public NuevoSuplidor()
        {
            InitializeComponent();
        }
        
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FacturacionSysDLL.DATA.TBL_Suplidor suplidor = new FacturacionSysDLL.DATA.TBL_Suplidor();
                var suplidorModel = new SuplidorC ();

                suplidor.Nombres = txtnombre.Text;
                suplidor.Apellidos = txtapellido.Text;
                suplidor.NumIdentif = txtcedula.Text;
                suplidor.Telefono1 = txttelefono.Text;
                suplidor.Email = txtemai.Text;
                suplidor.Direccion = txtdireccion.Text;
                suplidor.Descripcion = txtnombre.Text + " " + txtapellido.Text;
                suplidor.CodSuplidor = this.CodSuplidor;
                suplidorModel.Guardar(suplidor);
                MessageBox.Show("Guardado satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Editar(int id)
        {
            SuplidorC suplidor = new SuplidorC();
            var result = suplidor.BuscarPorID(id);
            txtnombre.Text = result.Nombres;
            txtapellido.Text = result.Apellidos;
            txtcedula.Text = result.NumIdentif;
            txtdireccion.Text = result.Direccion;
            txtemai.Text = result.Email;
            txttelefono.Text = result.Telefono1;
            
            this.CodSuplidor = id;
            this.ShowDialog();

        }
    }
    }

