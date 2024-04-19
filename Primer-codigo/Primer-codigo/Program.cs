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
                Console.Write("dame un numero para tu tabla");
                int tabla = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine("{0} X {1} = {2}", tabla, i, tabla * i);
                }
                Console.Write("Presionar cualquier tecla para continuar");
                continuar = !Console.ReadLine().Equals("s");
                    }




        
        }
    }
}
