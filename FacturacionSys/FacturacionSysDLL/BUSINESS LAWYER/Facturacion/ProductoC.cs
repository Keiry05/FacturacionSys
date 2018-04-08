using FacturacionSysDLL.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionSysDLL.BUSINESS_LAWYER.Facturacion
{
    public class ProductoC
    {

        public List<SP_BUSCARPRODUCTOS_Result> BuscarListadoProductos(string referencia = "", string descr = "")

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = dbContext.SP_BUSCARPRODUCTOS(descr, referencia).ToList();
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
            public FacturacionSysDLL.DATA.TBL_Producto BuscarPorID(int ID)

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = from a in dbContext.TBL_Producto
                                 where a.CodProducto == ID
                                 select a;

                    return result.FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Guardar(TBL_Producto model)
        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {

                    if (model.Referencia == "")
                    {
                        throw new Exception("Debe capturar la referencia");
                    }
                    if (model.Descripcion == "")
                    {
                        throw new Exception("Debe capturar la descripción");
                    }
                    if (model.Precio > 0)
                    {
                        throw new Exception("Debes ingresar el precio del producto");
                    }

                    if (model.Costo > 0)
                    {
                        throw new Exception("Debe Capturar el costo del producto");
                    }
                   
                    if (model.CodProducto == 0)
                    {
                        dbContext.TBL_Producto.Add(model);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        dbContext.Entry(model).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
  