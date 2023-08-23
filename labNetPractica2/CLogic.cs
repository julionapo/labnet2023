using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class CLogic : Exception 
    {
        public CLogic() : base("Aca estoy en la base...")
        {

        }
        public void ej3() 
        {
            throw new NotImplementedException();
        }
        public string Message(Exception ex) 
        {
            string msg = "";
            msg = Convert.ToString("Ubicacion y nombre de la excepcion: " + ex.GetType()) + "Mensaje del ejercicio 4 excepcion gral.:" + ex.Message;
            return msg;
        }
        

    }
}
