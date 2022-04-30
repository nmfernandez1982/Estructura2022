using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.Clear();   
            int x=12;
            int y=12;
            int suma=0;         
            suma=sumar(x,y);    
            Console.WriteLine("Total de suma Main:"+suma);      
              
        }

        static int sumar(int a,int b)
        {
        int suma=0;    
        suma=(a+b);   
         
        return suma;                                
        }
        
    }
}
