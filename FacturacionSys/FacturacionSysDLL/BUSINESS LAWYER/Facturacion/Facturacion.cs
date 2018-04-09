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
    class Facturacion
    {

    }   public void Guardar(TBL_Factura model,List<TBL_Factura_D> detalle)
        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {

                    if (model.CodFactura == 0)
                    {

                        dbContext.TBL_Factura.Add(model);
                        dbContext.SaveChanges();
                        var a=model.CodFactura;
                        
                        
                        foreach (var det in detalle)
                        {

                            det.CodFactura = model.CodFactura;
                            dbContext.TBL_Factura.Add(det);
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
