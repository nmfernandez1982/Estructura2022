using System;

namespace ejer07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Texto: ");
            string texto=Console.ReadLine();
            Console.WriteLine("Es igual: "+Analizar(texto));
        }


        static bool Analizar(string texto)
        {
            texto=texto.ToUpper();
            int j=texto.Length -1;

            for(int i=0;i<j;i++)
            {
                if(texto[i]!=texto[j])
                {
                    return false;
                }
                j--;
            }
            return true;
        }




    }
}
