using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {         
            string oracion = "1100 1010 0011 1010 0001 1000 0100 1001 1000";
            int ceros = 0;
            int unos = 0;

            
            for(int i = 0; i < oracion.Length; i++)
            {
                if(oracion[i] == ' ') { continue; }
                if(oracion[i] == '0')
                {
                    ceros++;
                }
                else
                {
                    unos++;
                } 
            }
            Console.WriteLine($"Ceros: {ceros}\nUnos: {unos}");
    }
}
}
