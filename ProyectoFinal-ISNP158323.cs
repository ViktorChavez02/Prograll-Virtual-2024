    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            while (continuar)
            {
                Console.WriteLine("::.. MENU ..::");
                Console.WriteLine("1. Saludo a David");
                Console.WriteLine("2. Suma de solo positivos");
                Console.WriteLine("3. Sueldo de operarios");
                Console.WriteLine("4. Impares Entre 0 y 100");
                Console.WriteLine("5. Tabla de Multiplicar");
                Console.WriteLine("6. Promedio");
                Console.WriteLine("7. Cuadrado de un numero");
                Console.WriteLine("8. Positivo O Negativo");
                Console.WriteLine("9. Par o Impar");
                Console.WriteLine("10. Promedio de edad de 15 Estudiantes");

                Console.WriteLine("Salir cualquier otro numero");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        SaludoNombre();
                        break;
                    case 2:
                        Console.Clear();
                        SumaDePositivos();
                        break;
                    case 3:
                        Console.Clear();
                        SueldoOperarios();
                        break;
                    case 4:
                        Console.Clear();
                        NumerosImpares();
                        break;
                    case 5:
                        Console.Clear();
                        TablaMultiplicar();
                        break;
                    case 6:
                        Console.Clear();
                        Promedio();
                        break;
                    case 7:
                        Console.Clear();
                        CuadradoDeNumero();
                        break;

                    case 8:
                        console.Clear();
                        Positivo_Negativo();
                        break;
                    case 9:
                    console.Clear();
                        

                    default:
                        continuar = false;
                        break;

                }
            }
        }

        static void SaludoNombre() {
            Console.WriteLine("Confirma si eres David escribiedo tu Nombre");
            string nombre = Console.ReadLine().ToLower();

            if (nombre == "david")
            {
                Console.WriteLine("Hola David");
            }
            else
            {
                Console.WriteLine("No te Conozco ");
            }
        }

        static void SumaDePositivos()
        {

            int num = 0, numin = 0;
            Boolean seg = true;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numin = int.Parse(Console.ReadLine());
                if (numin >= 1)
                {
                    num += numin;
                    Console.WriteLine(" Al sumar {0} el nuevo resultado es {1}", numin, num);
                    seg = true;
                }
                else if (numin <= 0)
                {
                    seg = false;

                }

            }
            while (seg == true);
        }

        static void SueldoOperarios()
        {
           
                    
        }
        static void NumerosImpares()
        {
            int numero = 0;
            Console.WriteLine("bienvenido");

            while(numero <= 100)
            {

                numero += 1;
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
;
                }
                else
                {
                    continue;
                }
            }
         
        }
        static void TablaMultiplicar()
        {
            Console.WriteLine("Tabla de multiplicar: ");
            int tabla = int.Parse(Console.ReadLine());

            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("{0}X{1}={2}", tabla, i, tabla * i);

            }
        }

        static void Promedio() {


            int resultado =0, count = 0;
            Boolean final = true;
            do
            {

                Console.WriteLine("Ingresa un numero: ");
                int numero = int.Parse(Console.ReadLine());

                resultado += numero;
                count++;
               
                if (count == 5)
                {
                    resultado /= 5;
                    Console.WriteLine("el promedio es: {0}", resultado);
                    final = false;

                }
                else
                {
                    continue;
                }


            }while(final == true);
           

        }
        static void CuadradoDeNumero()
        {
            double cuadrado;
                
            Boolean seguir = true;

            while(seguir == true){

                Console.WriteLine("Ingrese un Numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    cuadrado = Math.Pow(numero, 2);

                    Console.WriteLine("Cuadrado de {0} es {1}", numero, cuadrado);
                    seguir = false; 
                }
                else
                {
                    Console.WriteLine("ERROR. Reingresar Numero");
                    continue;
                }
            }
            
        }
        static void Positivo_Negativo()
        {
            Console.WriteLine("Ingrese un Numero: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero > 0) {
                Console.WriteLine("El numero {0} es positivo", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} es negativo", numero);
            }
        }
    }