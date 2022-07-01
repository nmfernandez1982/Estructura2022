using System;

namespace ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=10;
            int exponente=3;

            Console.WriteLine(Potencia(numero,exponente));
        }

        static int Potencia(int numero,int exponente)
        {
            if(exponente==0)
            {
                return 1;
            }
            else
            {
                return numero * Potencia(numero,exponente);
            }

        }



    }
}
