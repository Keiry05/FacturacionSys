using FacturacionSysDLL.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionSysDLL.BUSINESS_LAWYER
{
    public class SuplidorC
    {
        public List<SP_BUSCARSUPLIDOR_Result> buscarListadoSuplidor(string cedula = "", string descr = "")
        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = dbContext.SP_BUSCARSUPLIDOR(descr, cedula).ToList();
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        public FacturacionSysDLL.DATA.TBL_Suplidor BuscarPorID(int ID)

        {
            try
            {

                using (FacturacionSysDBEntities dbContext = new FacturacionSysDBEntities())
                {
                    var result = from a in dbContext.TBL_Suplidor
                                 where a.CodSuplidor == ID
                                 select a;

                    return result.FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Guardar(TBL_Suplidor model)
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

                    if (model.Telefono1 == "")
                    {
                        throw new Exception("Debe Capturar el teléfono");
                    }

                    if (model.CodSuplidor == 0)
                    {
                        dbContext.TBL_Suplidor.Add(model);
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
  
    