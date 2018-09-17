using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class program
    {
        static void Main(string[] args)
        {
            // Playing with Database
            var context = new Database2Entities();

            var products = context.Products;
            foreach (var product in products
                .Where(x => x.Name.Contains("o")))
                Console.WriteLine(product.Name);

            Console.WriteLine();

            var prod = products.First(x => x.Name.Contains("glove"));
            Console.WriteLine(prod.Name);

            prod.Name = "Faux glove Fur Hat";
            //context.SaveChanges();

            products = context.Products;
            foreach (var product in products)
                Console.WriteLine(product.Name);

            context.Products.Remove(prod);
            context.SaveChanges();

            Console.WriteLine();
            foreach (var product in products)
                Console.WriteLine(product.Name);

            Console.Read();

        }
    }
}
