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

                        foreach (var det in detalle)
                        {

                            dbContext.ConsumirExistencia(det.CodProducto, det.Cantidad);
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
        public List<SP_BUSCARPEDIDO_Result> BuscarListadoPedidosPendiente()

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = dbContext.SP_BUSCARPEDIDO().ToList();
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public FacturacionSysDLL.DATA.SP_BUSCARPEDIDO_BYIDN_Result BuscarPorID(int ID)

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = dbContext.SP_BUSCARPEDIDO_BYIDN(ID);

                    return result.FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<SP_BUSCARPEDIDO_DETALLE_Result> BuscarDetalle(int ID)

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = dbContext.SP_BUSCARPEDIDO_DETALLE(ID);

                    return result.ToList();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
