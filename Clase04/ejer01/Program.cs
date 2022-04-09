using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arrayInt={12,34,512,45,23,123,123,444,111,223,1500,1,345,90,3};
                      

           for(int x=0;x<arrayInt.Length;x++)
           {
            Console.WriteLine("Elemento: " + arrayInt[x] + " en la pos. ["+x+"]");    
           }


            foreach(int aux in arrayInt)
            {               
                Console.Write(Array.IndexOf(arrayInt, aux));
            }


        }
    }
}
