using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;

            while (continuar.Equals(true)) {
                Console.Clear();
                Console.WriteLine("Ingrese su nombre: ");
                String nombre = Console.ReadLine();

                Console.WriteLine("\nIngrese su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIngrese su sexo(Mujer=M, Hombre=H): ");
                String sexo = Console.ReadLine();

                if (sexo == "M" || sexo == "m")
                {
                    Console.WriteLine("\nLa Sra." + nombre + " ha sido registrada");

                }
                else if (sexo == "H" || sexo == "h")
                {
                    Console.WriteLine("\nEl Sr." + nombre + " ha sido registrado");

                }

                Console.WriteLine("\n¿Desea continuar? (s/n)");
                String decision = Console.ReadLine();

                if (decision == "S" || decision == "s")
                {
                    continuar = true;

                }
                else if (decision == "N" || decision == "n")
                {
                    continuar = false;
                    Environment.Exit(0);
                }
            }

            Console.Read();
        }
    }
}
