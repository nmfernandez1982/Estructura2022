using System;
using System.Collections.Generic;

namespace ejer05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<char> pilaVocales = new Stack<char>();
            Queue<char> colaConsonantes = new Queue<char>();

            const string MSJ_INGRESAR_FRASE = "Ingresar Una Frase: ";
            string frase;

            frase = IngresarString(MSJ_INGRESAR_FRASE);

            Console.WriteLine();
            Console.WriteLine("Frase ingresada: {0}",frase);

            SepararLetras(frase,ref pilaVocales, ref colaConsonantes);

            Console.WriteLine();
            MostrarPila(pilaVocales);

            Console.WriteLine();
            MostrarCola(colaConsonantes);

            
        }
        static string IngresarString(string msj)
        {
            string ingreso;

            Console.Write(msj);
            ingreso = Console.ReadLine().ToUpper();

            return ingreso;
        
        }
        static void SepararLetras(string frase, ref Stack<char> pilaVocales, ref Queue<char> colaConsonantes)
        {

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O' || frase[i] == 'U')
                {
                    pilaVocales.Push(frase[i]);
                }
                else
                { 
                    colaConsonantes.Enqueue(frase[i]);
                }

            }
        }
        static void MostrarPila(Stack<char> pilaVocales)
        {
            Console.WriteLine("Vocales dentro de la Fila: ");
            foreach (char vocal in pilaVocales)
            {
                Console.Write(vocal+" - ");
            }
            
        
        }
        static void MostrarCola(Queue<char> colaConstantes)
        {
            Console.WriteLine("Consonantes dentro de la Cola: ");
            foreach (char vocal in colaConstantes)
            {
                Console.Write(vocal + " - ");
            }
            

        }

    }
}