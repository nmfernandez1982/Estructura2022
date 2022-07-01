using System;

namespace ejer06
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Factorial es: "+(x=FactorialIteracion(4)));
            Console.WriteLine("Factorial es: "+(y=FactorialRecursivo(4)));
        }

        static int FactorialRecursivo(int numero)
        {
            if(numero==0)
            {
                return 1;
            }
            else
            {
                return numero * FactorialRecursivo(numero-1);
            }
        }

        static int FactorialIteracion(int numero)
        {        
            int resul=1;
            for (int i = 1; i<=numero; i++)
            {
                resul=resul*i;
            }
            return resul;
        }




    }
}
