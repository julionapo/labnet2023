using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqTP
{
    class Program
    {

        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            // practica4E1(db);
            // practica4E2(db);
            // practica4E3(db);
            // practica4E4(db);
            // practica4E5(db);
            // practica4E6(db);
            //practica4E7(db);
            //practica4E8(db);
            practica4E9(db);




            Console.ReadKey();
        }

        static void practica4E9(DataClasses1DataContext db)
        {
            var consulta = db.Products.OrderBy(prod => prod.ProductName);
            foreach (Product prod in consulta)
            {
                Console.WriteLine(prod.ProductName + ", stock:" + prod.UnitsInStock.ToString());
            }
        }
        static void practica4E8(DataClasses1DataContext db)
        {
            var consulta = from c in db.Customers
                           where c.Region == "WA"
                           select c;
            foreach (Customer cus in consulta.Take(3))
            {
                Console.WriteLine(cus.CustomerID + ", region: " + cus.Region);
            }
        }
        // ejercio 7: join entre customer y order cuando los customer tienen region WA y el order fecha mayor a 1/1/97
        static void practica4E7(DataClasses1DataContext db)
        {
            var consulta = from c in db.Customers
                           join o in db.Orders
                                on c.CustomerID equals o.CustomerID
                           where (
                                c.Region == "WA"
                                &&
                                o.OrderDate > (new DateTime(1997,01,01))
                                )
                           select new
                           {
                               c,
                               o
                           };
            foreach( var res in consulta)
            {
                Console.WriteLine("CusomerID: " + res.c.CustomerID + ", orderID: " + res.o.OrderID + ", " + res.o.OrderDate.ToString());
            }
        }

        // ejercicio 6: devolver los nombres de los customer en minuscula y mayuscula
        static void practica4E6(DataClasses1DataContext db)
        {
            var consulta = from c in db.Customers
                           select c;
            foreach (Customer cus in consulta)
            {
                Console.WriteLine("minuscula: " + cus.CompanyName.ToLower() + ", MAYUSCULA: " + cus.CompanyName.ToUpper());
            }
        }

        // ejercicio 5: devolver el primer producto que tiene por id 789
        static void practica4E5(DataClasses1DataContext db)
        {
            var consulta = from p in db.Products
                           where p.ProductID == 789
                           select p;
            if( consulta.Count() > 0)
            {
                Product prod = consulta.First();
                Console.WriteLine(prod.ProductName + ", id:" + prod.ProductID.ToString()); 
            } else
            {
                Console.WriteLine("No existe el producto");
            } 
        }

        // ejercicio 4: devolver los customer cuya region sea WA
        static void practica4E4(DataClasses1DataContext db)
        {
            var consulta = from c in db.Customers
                           where c.Region == "WA"
                           select c;
            foreach (Customer cus in consulta)
            {
                Console.WriteLine(cus.CustomerID + ", region: " + cus.Region);
            }
        }

        // ejercicio 3: devolver los productos con stock y cuyo precio unitario sea mayor a 3
        static void practica4E3(DataClasses1DataContext db)
        {
            var consulta = from p in db.Products
                           where (
                                p.UnitsInStock > 0
                                &&
                                p.UnitPrice > 3
                           )
                           select p;
            foreach (Product prod in consulta)
            {
                Console.WriteLine(prod.ProductName + ", stock:" + prod.UnitsInStock.ToString() + ", unitPrice:" + prod.UnitPrice.ToString());
            }
            Console.WriteLine(consulta.Count().ToString());
        }

        // ejercicio 2: devolver todos los productos sin stock
        static void practica4E2(DataClasses1DataContext db)
        {
            var consulta = from p in db.Products
                           where p.UnitsInStock == 0
                           select p;
            foreach (Product prod in consulta)
            {
                Console.WriteLine(prod.ProductName + ", stock:" + prod.UnitsInStock.ToString());
            }
        }

        // ejercicio 1: devolver objeto customer
        static void practica4E1(DataClasses1DataContext db)
        {
            // hago la query de los customer
            var consulta = from c in db.Customers
                           select c;
            // a modo de ejemplo, traigo sus CustomerID y ContactName
            foreach (Customer cus in consulta)
            {
                Console.WriteLine(cus.CustomerID + " - " + cus.ContactName);
            }

        }
    }
}
