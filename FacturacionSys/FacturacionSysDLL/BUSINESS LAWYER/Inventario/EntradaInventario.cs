using FacturacionSysDLL.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionSysDLL.BUSINESS_LAWYER.Inventario
{
   public class EntradaInventario
    {

        public void Guardar(TBL_InventarioMovimiento model, List<TBL_InventarioMovimiento_D> detalle)
        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {

                    if (model.CodMovimiento == 0)
                    {

                        dbContext.TBL_InventarioMovimiento.Add(model);
                        dbContext.SaveChanges();
                        var a = model.CodMovimiento;
                        foreach (var det in detalle)
                        {

                            det.CodMovimiento = model.CodMovimiento;
                            dbContext.TBL_InventarioMovimiento_D.Add(det);
                            dbContext.SaveChanges();
                        }

                        foreach (var det in detalle)
                        {
                            
                            dbContext.ActualizarExistencia(det.CodProducto, det.Cantidad,det.Costo);
                            dbContext.SaveChanges();
                        }
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
        public List<ConsultarEntradasInventario_Result> BuscarListadoEntradas()

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = dbContext.ConsultarEntradasInventario().ToList();
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
