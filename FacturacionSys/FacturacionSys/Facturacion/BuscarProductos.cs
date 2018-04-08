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
    public partial class BuscarProductos : Form
    {

        public string referencia { get; set; }


        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var CreaProdi = new Nuevo_Producto();
            CreaProdi.ShowDialog();
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Product = new ProductoC();
        
            dataGridProductos.DataSource = Product.BuscarListadoProductos(txtReferenciaB.Text, txtDescripcionB.Text);
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            
            button.Name = "btnAgregarProd";
            button.HeaderText = "Button";
            button.Text = "Agregar";
            button.UseColumnTextForButtonValue = true; //dont forget this line
            this.dataGridProductos.Columns.Add(button); 
        
        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Realizar_Pedido frmRealizarPedido = new Realizar_Pedido();
            //frmRealizarPedido.
        }


    }
    }
