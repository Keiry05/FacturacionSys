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
    public class Pedido
    {

        public void Guardar(TBL_Pedido model,List<TBL_Pedido_D> detalle)
        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {

                    if (model.CodPedido == 0)
                    {

                        dbContext.TBL_Pedido.Add(model);
                        dbContext.SaveChanges();
                        var a=model.CodPedido;
                        
                        
                        foreach (var det in detalle)
                        {

                            det.CodPedido = model.CodPedido;
                            dbContext.TBL_Pedido_D.Add(det);
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
    }
}
