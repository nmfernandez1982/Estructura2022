using System;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto=Console.ReadLine();
            string textoInvertido= invertir(texto);
            Console.WriteLine("Texto Invertido: "+textoInvertido);

            
            Persona p1=new Persona();
            Persona p2=new Persona();
            Persona p3=new Persona();
            
            p1.apellido="Fernandez";
            p1.nombre="Nicolas";
            p1.edad=40;

            Console.WriteLine(p1.imprimir());
            


        }

        public static string invertir(string t)
        {
            string t_invertido=string.Empty;
                for (int i = t.Length-1; i >=0; i--)
                {
                    t_invertido+=t.Substring(i,1);
                
                }
            return t_invertido;

        }




    }
}
