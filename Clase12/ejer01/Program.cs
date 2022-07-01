using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor: ");
            string numero= Console.ReadLine();
            int valor=0;
            valor=SumarDigitos(numero);
            Console.WriteLine("Suma de los digitos: "+valor);
        }


        public static int SumarDigitos(string numero)
        {
            int sum=0;

            for(int i=0;i<numero.Length;i++)
            {
                sum+=Convert.ToInt32(numero.Substring(i,1));
            }
            return sum;
        }



    }
}
