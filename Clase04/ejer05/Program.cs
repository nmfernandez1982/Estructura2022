using System;

namespace ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores =new int[50];
            Random rnd=new Random();
            int par=0;
            int impar=0;
            
            for(int x=0;x<valores.Length;x++)
            {
                valores[x]=rnd.Next(100,1000);
                Console.WriteLine("valor Nro.:"+valores[x]);
                if(valores[x]%2==0)
                {   
                    par++;
                }
                else
                {
                    impar++;
                }                            
            }

            Console.WriteLine("Cantidad de Pares:"+par);
            Console.WriteLine("Cantidad de impares:"+impar);









        }
    }
}
