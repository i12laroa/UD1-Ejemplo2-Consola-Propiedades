using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo2_Consola_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1, "Alberto", 2000);
            Console.WriteLine("Comienzo del curso");

            Console.WriteLine("El primer trabajor se llama: " + empleado1.Nombre + " y su salario es: " + empleado1.Salario);
            Console.WriteLine($"el primer trabajador se llama {empleado1.Nombre}");


            empleado1.CodigoEmpleado = 20;

            
        }
    }
}
