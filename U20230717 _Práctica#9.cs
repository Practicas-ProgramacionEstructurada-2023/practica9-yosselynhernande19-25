using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;

            do
            {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1.Multiplicar números ");
            Console.WriteLine("2.Restar números ");
            Console.WriteLine("3.Concatenar cadenas ");
            Console.WriteLine("4. Salir");
            Console.Write("\nIngrese su opción: "); 

             if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                {  
                        case 1:

                            Console.WriteLine("\nIngrese dos números enteros para multiplicar: ");
                        
                            Console.Write("\nNúmeros 1:");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nNúmeros 1:");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nResultado de la múltiplicación (entero):" + Multiplicar(num1,num2));

                            Console.WriteLine("\nIngrese dos números decimales para multiplicar: ");

                            Console.Write("\nNúmeros 1:");
                            double num1Double  = Convert.ToDouble(Console.ReadLine());

                            Console.Write("\nNúmeros 2:");
                            double num2Double = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\nResultado de la múltiplicación (decimal):" + Multiplicar(num1Double, num2Double));
                            break;

                        case 2:

                            Console.WriteLine("\nResultado es:" + RestarNumeros(20, 5, 3, 2));
                            break;

                        case 3:
                            Console.Write("\nIngrese su primer nombre:");
                            string? cadena1 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su primer apellido:");
                            string? cadena2 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese el separador:");
                            string? separador = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenación = ConcatenarCadenas(cadena1, cadena2, separador);
                            Console.WriteLine($"\n Resultado de la concatenación: {resultadoConcatenación}");


                            Console.Write("\nIngrese su segundo nombre:");
                            string? cadena3 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su segundo apellido:");
                            string? cadena4 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su tercer apellido:");
                            string? cadena5 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese el separador2:");
                            string? separador2 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenación2 = ConcatenarCadenas(cadena3, cadena4, cadena5, separador2);
                            Console.WriteLine($"\n Resultado de la concatenación: {resultadoConcatenación2}");
                            break;

                        case 4:
                            Console.WriteLine($"\nSaliendo del programa...");
                            break;
                        default:
                           Console.WriteLine("Opción no válida, Intente de nuevo");
                           break;   
                
                }

                }
                else
                {
                    Console.WriteLine("\nOpción no válida. Intente de nuevo");
                }   

            } while (opcion !=4);

        }//Fin del Main

         static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static int RestarNumeros(params int[] numeros)
        {
            int resultado = numeros[0]; // Inicializamo el resulado con el primer número

            for (int i = 1; i < numeros.Length; i++)
            {
               resultado -= numeros[i]; //Restamos los números uno por uno
            }

            return resultado;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? separador1)
        {
            return cadena1 + separador1 + cadena2;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? cadena3, string? separador1 )
        {
            return cadena3 + separador1 + cadena2 + separador1 + cadena3;
        }
    }
}
