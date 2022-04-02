using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Nro. 02");

            Console.Clear();
            String oracion1="";
            String oracion2="";
            int valor1;
            int valor2;

            oracion1="LA CASA";
            oracion2="es de madera";

            oracion1=oracion1.ToLower();
            oracion2=oracion2.ToUpper();

            Console.WriteLine("La oracion completa es: "+oracion1+" "+oracion2);

            Console.WriteLine("La cantidad de letras de oracion 1 es:" +oracion1.Length );   
            Console.WriteLine("La cantidad de letras de oracion 2 es:" +oracion2.Length );  

            Console.ReadKey();

        }
    }
}
