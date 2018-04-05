using FacturacionSysDLL.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionSysDLL.BUSINESS_LAWYER.Menu
{
    public class LoginC
    {
        public bool Logguear(string Usuario, string contrasena)
        {
            try{
                bool retorno = true;
                using (FacturacionSysDBEntities dbContext =new FacturacionSysDBEntities())
                {
                    var usuarios = (from usr in dbContext.Usuarios
                                    where usr.Usuario==Usuario && usr.Contrasena==contrasena
                                    select usr).ToList();
                    if(usuarios.Count<=0 )
                    {
                        return false;
                    }

                }
                return retorno;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }

        }
    }
}
