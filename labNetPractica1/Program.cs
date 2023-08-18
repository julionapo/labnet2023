using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listado de vehiculos: ");

            List<CTransportePublico> Lista = new List<CTransportePublico>();
            Random r= new Random();
            int cT = 5, cO = 5, n;

            for (int i = 0; i < 10; ++i)
            {
                CTransportePublico vehiculo;
               //0 es taxi y 1 es omnibus
                n= r.Next(0,2);
                if (cT==0)n= 1;
                if (cO==0)n= 0;
                if (n == 0)
                {
                    cT -= 1;
                    vehiculo = new CTaxi();
                    vehiculo.AgregarPasajero(r.Next(1,4));
                }
                else
                {
                    cO -= 1;
                    vehiculo=new COmnibus();
                    vehiculo.AgregarPasajero(r.Next(1,46)) ;
                }
                Lista.Add(vehiculo);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Lista[i]);
            }
        }
    }
}
