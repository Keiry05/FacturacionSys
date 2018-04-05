using FacturacionSysDLL.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionSysDLL.BUSINESS_LAWYER.Facturacion
{
    public class ProductoC
    {

        public System.Collections.Generic.List<FacturacionSysDLL.DATA.TBL_Producto> BuscarListadoProductos(string referencia="", string descr="")

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    //var result= (from c in dbContext.TBL_Producto
                    //              join cn in dbContext.TBL_ProductoExistencia on c.CodProducto equals cn.CodProducto
                                 
                    //              where (c.Referencia == referencia) || (c.Descripcion== descr) 
                    //              select new { descripcion=c.Descripcion, referencia = c.Referencia, c.Precio, cn.Cantidad,c.CodProducto }).ToList();


                    //return result;
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}
