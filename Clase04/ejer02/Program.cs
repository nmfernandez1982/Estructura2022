using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores=new int[20];
            Random rnd=new Random();
            int minimo=0;
            int maximo=0;

            //asigno valores aleatorios.

        for(int x=0;x<valores.Length;x++)
        {
            valores[x]=rnd.Next(10,100);
            Console.WriteLine("Valor :"+valores[x]+"{"+x+"}");
        }

        for(int x=0;x<valores.Length;x++)
        {
            if(valores[x]>maximo)
            {
                maximo=valores[x];
            }                       
        }
        Console.Write("EL numero maximo es:"+maximo);

        minimo=maximo;

        for(int x=0;x<valores.Length;x++)
        {
            if(valores[x]<minimo)
            {
                minimo=valores[x];
            }                       
        }
        Console.Write("EL numero minimo es:"+minimo);











        }
    }
}
