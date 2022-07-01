using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto=Console.ReadLine();
            int posicion=Convert.ToInt32(Console.ReadLine());
            char letra=Convert.ToChar(Console.ReadLine());


            texto=CambiarLetra(texto,posicion,letra);
            Console.WriteLine("Texto: "+texto);

        }


        public static string CambiarLetra(string texto,int posicion,char letra)
        {
            texto=texto.Remove(posicion,1);
            texto=texto.Insert(posicion,letra.ToString());
            return texto;
        }





    }
}
