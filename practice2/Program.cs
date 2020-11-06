using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            static double[] cargar(  )
            {
                 double salario;


                Console.WriteLine("empleado 1: Mario Jimenez");
                string empleado1 = Console.ReadLine();
                double salario1 = 345000;

                Console.WriteLine("empleado 1:  Neysha Alvarez" );
                string empleado2 = Console.ReadLine();
                double salario2 = 34000;

                Console.WriteLine("empleado 1:  Neysha Alvarez" );
                string empleado3 = Console.ReadLine();
                double salario3 = 54000;

                Console.WriteLine("empleado 1:  Neysha Alvarez" );
                string empleado4 = Console.ReadLine();
                double salario4 = 34000;
            Console.WriteLine("empleado 1:  Marlo Roger");
                string empleado5 = Console.ReadLine();
                double salario5 = 5200;
                return (cargar());

            }


            static double Salariomayor()
            {

                
                Console.WriteLine("El empleado con el salario mayor es", cargar() );



                return (Salariomayor());

            }



        }
    }
}
