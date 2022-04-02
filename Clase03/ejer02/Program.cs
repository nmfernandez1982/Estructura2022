using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int suma=0;

            for(int x=0;x<100;x++)
            {
                Console.WriteLine("Valor de x:"+x);  
                suma=suma+x;
            }
            Console.WriteLine("Valor de suma:"+suma);  


        }
    }
}
