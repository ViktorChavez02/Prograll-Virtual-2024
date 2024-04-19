using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_codigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            while (continuar) {
                Console.Clear();
                int a = 1, b = 0, c = 0;
                do { 
                    c = a+b ;
                    Console.WriteLine("{0}+{1}={2}", a,b,c);
                    b= a ;
                    a = c ;

                } while ( a <= 1000);
                
                Console.Write("Presionar cualquier tecla para continuar");
                continuar = !Console.ReadLine().Equals("s");
                    }




        
        }
    }
}
