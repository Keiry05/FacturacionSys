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

        public List<SP_BUSCARPRODUCTOS_Result> BuscarListadoProductos(string referencia="", string descr="")

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result=dbContext.SP_BUSCARPRODUCTOS(descr, referencia).ToList();
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}
