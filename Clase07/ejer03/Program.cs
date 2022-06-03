using System;

namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNac;
            DateTime diadehoy=DateTime.Now;

            Console.WriteLine("Ingrese la fecha de Nacimiento:");
            fechaNac=DateTime.Parse(Console.ReadLine());
            Console.WriteLine(-fechaNac.Year+diadehoy.Year);
        }
    }
}
