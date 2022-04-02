using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Nro. 01");
            int a=0;
            int b=0;
            int c=100;


            Console.Write("Ingrese Valor A: ");
            a=int.Parse(Console.ReadLine());

            Console.Write("Ingrese Valor B: ");
            b=int.Parse(Console.ReadLine());
                  
            
            c=c+(a+b);
          

            Console.WriteLine("-----------------");
            Console.WriteLine("El resultado es: "+ c );
            Console.WriteLine("-----------------");





            //a=Convert.ToInt32(Console.ReadLine());





           





        }
    }
}
