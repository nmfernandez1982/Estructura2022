using System;
using System.IO;

namespace ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
          string ruta="c:/valen/log.txt";
          string contenido=DateTime.Now + " Inicio de Aplicacion";
          escribirLog(contenido,ruta);   

            int valor1=0;
            int valor2=0;
            int res=0;

        try
        {
            Console.Write("Ingrese Valor 1: ");
            valor1=Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese Valor 2: ");
            valor2=Int32.Parse(Console.ReadLine());

            res=valor1/valor2;
            Console.WriteLine("Resultado : "+res);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Division por 0");
            contenido=DateTime.Now + " Division por 0";
            escribirLog(contenido,ruta);
        }
        catch(FormatException)
        {
            Console.WriteLine("Dato No valido");
            contenido=DateTime.Now + " Dato No valido";
            escribirLog(contenido,ruta);
        }
        catch(Exception)
        {
            Console.WriteLine("Error");
            contenido=DateTime.Now + " Otro Error";
            escribirLog(contenido,ruta);
        }

        finally
        {
        contenido=DateTime.Now + " Fin de Ejecucion";
        escribirLog(contenido,ruta);
        }       


        }


        public static void escribirLog(string contenido,string ruta)
        {
            File.AppendAllLines(ruta,new String[]{contenido});
        }

    }
}
