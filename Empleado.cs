using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo2_Consola_Propiedades
{
    public class Empleado
    {

        private double salario;
        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public double Salario
        {
            get { return salario; }
            set
            {

                if (value < 0)
                {
                    Console.WriteLine("No puedes cambiar el salario por un valor negativo");
                }
                else
                {
                    salario = value;
                }
            }   
        }
        public Empleado(int codigoEmpleado, string nombre, double salario)
        {
            CodigoEmpleado = codigoEmpleado;
            Nombre = nombre;
            Salario = salario;
        }
    }   
}
