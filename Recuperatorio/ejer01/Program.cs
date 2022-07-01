using System;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
              int [,]  array2d=new int[4,4] { {1,4,5,2},{8,9,2,4},{6,8,9,0},{1,2,3,4}};

              char [,] array2dC=new char[4,4] {{'a','c','d','f'},{'f','r','t','y'},{'f','r','t','y'},{'f','r','t','y'}};

             for(int x=0;x<array2dC.GetLength(0);x++)
             {
                 for(int y=0;y<array2dC.GetLength(1);y++)
                {
                   Console.Write(array2dC[x,y]+"\t");                   
                }                
                Console.WriteLine("");
             }





        }
    }
}
