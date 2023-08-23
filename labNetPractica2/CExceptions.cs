using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public static class CExceptions
    {
        public static void DividePorCero(this int numero) 
        {
            try 
            {
                int resultado = numero / 0;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Intento de dividir por cero...");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin de la operacion...");
            }

        }
        public static void DividendoyDivisor(this int dividendo, int divisor) 
        {
            try
            {
                int resultado = dividendo / divisor;
                Console.WriteLine(resultado);
            }
               catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo el loco Palermo puede dividir por 0...");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Asi noooooo......"+ex.Message);
            }

        }

    }
}
