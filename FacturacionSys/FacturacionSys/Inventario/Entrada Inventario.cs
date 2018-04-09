using FacturacionSys.Facturacion;
using FacturacionSysDLL.BUSINESS_LAWYER;
using FacturacionSysDLL.BUSINESS_LAWYER.Facturacion;
using FacturacionSysDLL.BUSINESS_LAWYER.Inventario;
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

namespace FacturacionSys.Inventario
{
    public partial class Entrada_Inventario : Form
    {
        public Entrada_Inventario()
        {
            InitializeComponent();
        }
        ProductoC producto = new ProductoC();

     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductosIn products = new BuscarProductosIn();
            products.ShowDialog();

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }

        public void calcularImporte()
        {
            var valor = nudCantidad.Value * nupPrecio.Value;

            this.NupImporte.Value = valor;
            this.Show();
        }

        private void nupPrecio_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var codigoProducto = producto.BuscarCodigo(txtCodigoD.Text);
            dataGridProductos.Rows.Add(codigoProducto, txtCodigoD.Text, txtDescripcionD.Text, nudCantidad.Value,nupPrecio.Value, NupImporte.Value);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Entrada_Inventario_Load(object sender, EventArgs e)
        {
            LlenarCboClientes();
        }


        private void LlenarCboClientes()
        {
            var suplidor = new SuplidorC();
            cboSuplidor.DisplayMember = "Nombres";
            cboSuplidor.ValueMember = "Codigo";
            cboSuplidor.DataSource = suplidor.buscarListadoSuplidor("", "");

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
      
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FacturacionSysDLL.DATA.TBL_InventarioMovimiento inventario = new FacturacionSysDLL.DATA.TBL_InventarioMovimiento();
                var inventarioModel = new EntradaInventario();

                inventario.Cod_Suplidor = Convert.ToInt16(cboSuplidor.SelectedValue);
                inventario.Comentarios = txtComentarios.Text;
                inventario.Fecha = dtpFecha.Value;
                inventario.Estatus =1;

                List<TBL_InventarioMovimiento_D> lstDetalle = new List<TBL_InventarioMovimiento_D>();
                TBL_InventarioMovimiento_D detalle = new TBL_InventarioMovimiento_D();
                decimal monto_total = 0;
                if (dataGridProductos.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridProductos.Rows)
                    {
                        detalle.CodProducto = int.Parse(row.Cells["Codigo"].Value.ToString());
                        detalle.Costo = Convert.ToDecimal(row.Cells["Precio"].Value.ToString());
                        detalle.Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                        detalle.Importe = Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                        monto_total += Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                        lstDetalle.Add(detalle);
                    }
                }
                inventario.MontoTotal = monto_total;

                inventarioModel.Guardar(inventario, lstDetalle);
                MessageBox.Show("Guardado satisfactoriamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
