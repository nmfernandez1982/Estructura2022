using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;

            do{
            Console.Clear();
            Console.Write("Ingrese valor 1: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("ingrese Valor 2: ");
            b=int.Parse(Console.ReadLine());           

            if(a ==b)
            {
            Console.WriteLine("A y B son Iguales");
            Console.ReadKey();
            }
            }while(a==b);

            //Una linea

            /*
            varias lineas
            varias lineas
            */
            if(a>b)
            {
                Console.WriteLine("El valor de a es mayor");   
            }
            else 
            {
                Console.WriteLine("El valor de a es Menor");
            }


        }
    }
}
