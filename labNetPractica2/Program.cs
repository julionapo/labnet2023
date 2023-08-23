using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero=Convert.ToInt32(Console.ReadLine());
            CExceptions.DividePorCero(numero);

            try 
            {
                Console.WriteLine("Ingrese dividendo: ");
                int dividendo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                CExceptions.DividendoyDivisor(dividendo,divisor);

            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Ingrese un numero no una letra...");
                Console.WriteLine(ex.Message);
            }
            try
            {
                CLogic CLogic = new CLogic();
                CLogic.ej3();

            }

            catch(Exception ex)
            {
                Console.WriteLine("Surgio un error: "+ ex.Message);
                Console.ReadKey();
            }
            try
            {
                throw new CLogic();
            }
            catch (CLogic ex)
            {
                Console.WriteLine(ex.Message(ex));
                Console.ReadKey();
            }

        }
    }
}
