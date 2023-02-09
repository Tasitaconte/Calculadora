using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program{
        static void Main(string[] args){
            
            int x, y;
            int opcion;
            Console.WriteLine("1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
            do
            {
                Console.WriteLine("Digite su opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el primer numero");
                x = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Digite el segundo numero");
                y = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(calcular(opcion, x, y));
                
                Console.WriteLine("Presione Y para terminar");
                char fin = Console.ReadLine()[0];
                if (fin=='y' || fin=='Y'){
                    Environment.Exit(0);
                }
            }
            while(true);
        }

        //Function calcular;
        static int calcular(int opcion, int x, int y){
            switch (opcion){            
                case 1:
                    return x + y;
                case 2:
                    return x - y;
                case 3:
                    return x * y;
                case 4:
                    return x / y;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }
            return 0;
        }
    }
}
