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
    public partial class Realizar_Factura : Form
    {
        ProductoC producto = new ProductoC();

        int cod_pedido;
        public Realizar_Factura()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Realizar_Pedido_Load(object sender, EventArgs e)
        {
            LlenarCboClientes();
        }
        private void LlenarCboClientes()
        {
            var clientes = new ClienteC();
            cboClientes.DisplayMember = "Nombres";
            cboClientes.ValueMember = "Codigo";
            cboClientes.DataSource = clientes.BuscarListadoClientes("", "");

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
           
        }
        BuscarProductos products = new BuscarProductos();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            products.ShowDialog();
            products.Hide();
        }
        private void calcularImporte()
        {
            var valor = nudCantidad.Value * numprecio.Value - numdescuento.Value + txtItbis.Value;

            this.txtImporte.Value = valor;
            this.Show();
        }
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                var validaExt = producto.ValidarExistencia(txtCodigoD.Text, nudCantidad.Value);


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

        private void numprecio_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }

        private void numdescuento_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                var validaExt = producto.ValidarExistencia(txtCodigoD.Text, nudCantidad.Value);


                if (validaExt)
                {
                    var codigoProducto = producto.BuscarCodigo(txtCodigoD.Text);
                    dataGridproducto.Rows.Add(codigoProducto, txtCodigoD.Text,txtdescripcion.Text, nudCantidad.Value, numprecio.Value, txtItbis.Value, numdescuento.Value, txtImporte.Value);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FacturacionSysDLL.DATA.TBL_Factura pedidos = new FacturacionSysDLL.DATA.TBL_Factura();
                Factura pedidoModel = new Factura();

                pedidos.CodCliente = Convert.ToInt16(cboClientes.SelectedValue);
                pedidos.Fecha = dtpFecha.Value;
                pedidos.MontoDescuento = 0;

                List<TBL_Factura_D> lstDetalle = new List<TBL_Factura_D>();
                TBL_Factura_D detalle = new TBL_Factura_D();
                decimal monto_total = 0;
                if (dataGridproducto.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridproducto.Rows)
                    {
                        detalle.CodProducto = int.Parse(row.Cells["Codigo"].Value.ToString());
                        detalle.Descuento = Convert.ToDecimal(row.Cells["Descuento"].Value.ToString());
                        detalle.Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                        detalle.Importe = Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                        monto_total += Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                        lstDetalle.Add(detalle);
                    }
                }
                pedidos.MontoTotal = monto_total;

                pedidoModel.Guardar(pedidos, lstDetalle);
                MessageBox.Show("Guardado satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Editar(int id)
        {
            Pedido cliente = new Pedido();
            var result = cliente.BuscarPorID(id);
            var detale = cliente.BuscarDetalle(id);
            foreach (var det in detale)
            {
                dataGridproducto.AutoGenerateColumns = true;
                dataGridproducto.Rows.Add(det.CODPRODUCTO, det.Codigo, det.Producto, det.CANTIDAD, det.PRECIO, txtItbis.Value, det.DESCUENTO,det.IMPORTE);
            }
      
            LlenarCboClientes();
            cboClientes.SelectedValue = result.CodCliente;
            dtpFecha.Value = result.Fecha;
            txtOrden.Text = result.Codigo.ToString();
            this.cod_pedido = result.Codigo;
            this.ShowDialog();

        }

        private void dataGridproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

