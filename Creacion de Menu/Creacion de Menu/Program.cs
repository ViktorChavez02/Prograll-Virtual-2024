using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            while (continuar)
            {
                Console.WriteLine("::.. MENU ..::");
                Console.WriteLine("1. Determinar positivo o negativo");
                Console.WriteLine("2. numero del 1 al 10");
                Console.WriteLine("3. Suma de solo positivos");
                Console.WriteLine("4. suma de 5 numeros");
                Console.WriteLine("5. Promedio de numeros");
                Console.WriteLine("Salir cualquier otro numero");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        DeterminarNegopos();
                        break;
                    case 2:
                       Console.Clear();
                      Del1al10();
                      break;
                    case 3:
                     Console.Clear();
                        sumasolopos();
                      break;
                    //case 4:
                    //  Console.Clear();
                    // parImpar();
                    //break;
                    //case 5:
                    //  Console.Clear();
                    //determinarPrimo();
                    // break;
                    default:
                        continuar = false;
                        break;

                }
            }
        }
        static void DeterminarNegopos()
        {
            Console.Write(" Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
            {
                Console.WriteLine("el numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero ingresado es negativo");
            }

        }

        static void Del1al10()
        {
            int numero = 0;
            while (numero < 10) {

                numero++;
                Console.WriteLine(numero);
            }
        }
        static void sumasolopos()
        {
            int num = 0,numin = 0;
            Boolean seg = true;
            do {
                Console.WriteLine("Ingrese un numero: ");
                numin = int.Parse(Console.ReadLine());
                if (numin >= 1){
                    num += numin;
                    Console.WriteLine(" Al sumar {0} el nuevo resultado es {1}", numin, num);
                    seg = true;
                }
               else if(numin <= 0){
                    seg = false;

                }
            
            }
            while (seg == true);
        }
        static void suma5nums() { 
        
        }
    }
}
