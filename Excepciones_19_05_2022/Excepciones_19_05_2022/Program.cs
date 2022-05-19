using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_19_05_2022
{
    //Nombre: Santy Francisco Martinez Castellanos
    //N.Control: 21211989


    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
           
            try
            {
                Console.Write("Introduce un numero:");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Introduce otro numero:");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.WriteLine();
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
           
                
        }
    }
}
