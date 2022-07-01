using System;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1=5;
           int n2=4;
           Console.WriteLine("La Multiplicacion es: "+mul(n1,n2));
        }


        public static int mul(int n1,int n2)
        {
            if(n2==0)
            {
                return 0;
            }
            else
            {
                return n1 + mul(n1,n2-1);                
            }





        }





    }
}
