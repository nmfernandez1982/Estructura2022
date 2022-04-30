using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.Clear();   
            int x=12;
            int y=2;
            int suma=0;
            suma=(x+y);
            Console.WriteLine("Total de suma Main:"+suma);
            sumar();            
        }

        static void sumar()
        {
                Console.WriteLine("Funciones");
                int x=20;
                int y=2;
                int suma=0;
                suma=(x+y);
                Console.WriteLine("Total de sumar funcion sumar():"+suma);                    
        }

    }
}
