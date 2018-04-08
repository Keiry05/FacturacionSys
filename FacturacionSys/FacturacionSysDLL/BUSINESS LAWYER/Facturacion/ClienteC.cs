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
   public class ClienteC
    {

        
        public List<SP_BUSCARCLIENTES_Result> BuscarListadoClientes(string cedula="", string descr="")

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result=dbContext.SP_BUSCARCLIENTES(descr, cedula).ToList();
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }



        public FacturacionSysDLL.DATA.TBL_Cliente BuscarPorID(int ID)

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = from a in dbContext.TBL_Cliente
                                 where a.CodCliente == ID
                                 select a;
                                 
                    return result.FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Guardar(TBL_Cliente model)
            {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {

                    if (model.Nombres == "")
                    {
                        throw new Exception("Debe capturar el nombre");
                    }
                    if (model.Apellidos == "")
                    {
                        throw new Exception("Debe capturar los apellidos");
                    }
                    if (model.NumIdentif == "")
                    {
                        throw new Exception("Debe capturar la cedula");
                    }
                 
                    if (model.Telefono1 == ""|| model.Telefono2 == "")
                    {
                        throw new Exception("Debe Capturar al menos un teléfono");
                    }

                    if (model.CodCliente == 0) 
                    {
                        dbContext.TBL_Cliente.Add(model);
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
