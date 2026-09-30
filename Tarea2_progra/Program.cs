using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_progra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";

            while (continuar == "s")
            {
                Console.Write("Digite la cedula: ");
                string cedula = Console.ReadLine();

                Console.Write("Digite el nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.Write("Digite el tipo de empleado (1-3): ");
                int tipo = Int32.Parse(Console.ReadLine());

                Console.Write("Digite la cantidad de horas: ");
                double horas = Double.Parse(Console.ReadLine());

                Console.Write("Digite el precio por hora: ");
                double precioHora = Double.Parse(Console.ReadLine());

                double salarioOrdinario = horas * precioHora;
                double aumento;

                if (tipo == 1)
                {
                    aumento = salarioOrdinario * 0.15;
                }
                else if (tipo == 2)
                {
                    aumento = salarioOrdinario * 0.10;
                }
                else
                {
                    aumento = salarioOrdinario * 0.05;
                }

                double salarioBruto = salarioOrdinario + aumento;
                double deduccion = salarioBruto * 0.0917;
                double salarioNeto = salarioBruto - deduccion;

                Console.WriteLine("\n--- Datos del empleado ---");
                Console.WriteLine("Cedula: " + cedula);
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Tipo empleado: " + tipo);
                Console.WriteLine("Salario por hora: " + precioHora);
                Console.WriteLine("Cantidad de horas: " + horas);
                Console.WriteLine("Salario ordinario: " + salarioOrdinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario bruto: " + salarioBruto);
                Console.WriteLine("Deduccion CCSS: " + deduccion);
                Console.WriteLine("Salario neto: " + salarioNeto);

                Console.Write("\n¿Desea ingresar otro empleado? s/n: ");
                continuar = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Programa finalizado.");
        }
    }
}  
