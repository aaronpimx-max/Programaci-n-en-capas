using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("--Ejercicio 2--");
            Console.WriteLine("Ingrese el numero del Legajo:");

            if (int.TryParse(Console.ReadLine(), out int legajo))
            {
                string resultado = NegocioAlumno.Consultar(legajo, out Alumno alumno);

                if (resultado == "Éxito")
                {
                    Console.WriteLine($"Nombre: {alumno.Nombre} | Condición: {alumno.Condición}");
                }
                else
                {
                    Console.WriteLine($"{resultado}");
                }
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número entero válido.");
            }

            Console.ReadKey();
        
        }
    }
}
