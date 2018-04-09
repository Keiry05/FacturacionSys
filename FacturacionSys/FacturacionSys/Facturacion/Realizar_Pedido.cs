using FacturacionSysDLL.BUSINESS_LAWYER.Facturacion;
using FacturacionSysDLL.DATA;
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
    public partial class Realizar_Pedido : Form
    {
        ProductoC producto = new ProductoC();
        public Realizar_Pedido()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Realizar_Pedido_Load(object sender, EventArgs e)
        {
            LlenarCboClientes();
        }


        private void LlenarCboClientes()
        {
            var clientes = new ClienteC();
            cboCliente.DisplayMember = "Nombres";
            cboCliente.ValueMember = "Codigo";
            cboCliente.DataSource = clientes.BuscarListadoClientes("", "");
          
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
            dtpFechaCompromiso.Format = DateTimePickerFormat.Custom;
            dtpFechaCompromiso.CustomFormat = "yyyy-MM-dd";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    
        BuscarProductos products = new BuscarProductos();
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
           
            products.ShowDialog();
            products.Hide();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

            try
            {
              
                var validaExt=producto.ValidarExistencia(txtCodigoD.Text, nudCantidad.Value);


                if (validaExt)
                {

                    calcularImporte();
                }
                else
                {
                    throw new Exception("No puede agregar una cantidad mayor a la disponible en inventario");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void nudPrecioD_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }
        private void nupDescuentoD_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }


        private void calcularImporte()
            {
            var valor= nudCantidad.Value * nudPrecioD.Value - nupDescuentoD.Value + txtItbis.Value;

            this.txtImporte.Value =valor;
            this.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                var validaExt = producto.ValidarExistencia(txtCodigoD.Text, nudCantidad.Value);


                if (validaExt)
                {
                    var codigoProducto = producto.BuscarCodigo(txtCodigoD.Text);
                    dataGridProducto.Rows.Add(codigoProducto, txtCodigoD.Text, txtDescripcionD.Text, nudCantidad.Value, nudPrecioD.Value, txtItbis.Value, nupDescuentoD.Value, txtImporte.Value);
                }
                else
                {
                    throw new Exception("No puede agregar una cantidad mayor a la disponible en inventario");
                }
              
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FacturacionSysDLL.DATA.TBL_Pedido pedidos = new FacturacionSysDLL.DATA.TBL_Pedido();
                var pedidoModel = new Pedido ();

                pedidos.CodCliente = Convert.ToInt16(cboCliente.SelectedValue);
                pedidos.Comentarios = txtComentarios.Text;
                pedidos.Fecha = dtpFecha.Value;
                pedidos.FechaCompromiso = dtpFechaCompromiso.Value;
                pedidos.MontoDescuento = 0;
             
                List<TBL_Pedido_D> lstDetalle = new List<TBL_Pedido_D>();
                TBL_Pedido_D detalle = new TBL_Pedido_D();
                decimal monto_total=0;
                if (dataGridProducto.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridProducto.Rows)
                    {
                        detalle.CodProducto = int.Parse(row.Cells["Codigo"].Value.ToString());
                        detalle.Descuento = Convert.ToDecimal(row.Cells["Descuento"].Value.ToString());
                        detalle.Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                        detalle.Importe= Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                        monto_total += Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                        lstDetalle.Add(detalle);
                    }
                }
                pedidos.MontoTotal = monto_total;

                 pedidoModel.Guardar(pedidos,lstDetalle);
                MessageBox.Show("Guardado satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
