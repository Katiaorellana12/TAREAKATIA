using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATIATAREA
{
    public class Collection
    {
        public static void SortedListCollection()
        {
            //factorial de un numero n
            int n, cont, fact;
            Console.Write("Digite el valor de n! : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("El factorial de {0} es 1", n);
            }
            else
            {
                fact = n;
                for (cont = n; cont > 1; cont--)
                {
                    fact = fact * (cont - 1);
                }
                Console.WriteLine("El factorial de {0} es: {1} ", n, fact);
            }
            Console.ReadKey();
        }
    }
}
    
