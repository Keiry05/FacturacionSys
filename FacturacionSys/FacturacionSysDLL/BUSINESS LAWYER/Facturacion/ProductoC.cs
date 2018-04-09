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
        public bool ValidarExistencia(string referencia = "",decimal Cantidad=0)

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = dbContext.SP_BUSCARPRODUCTOS("", referencia).FirstOrDefault();
                    var retorno=true;
                    if (result.Cantidad < Cantidad)
                    {
                        retorno = false;
                        
                    }
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public int BuscarCodigo(string referencia)
        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var codigo = from prod in dbContext.TBL_Producto
                                 where prod.Referencia == referencia
                                 select prod.CodProducto;
                    return codigo.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
         
    }
}
