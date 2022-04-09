using System;

namespace ejer04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array={1,23,45,64,12,345,67,8,1,10};
            int[] array2={10,9,8,7,6,5,4,3,2,1};

            int[] array3=new int[20];


            array.CopyTo(array3,0);
            array2.CopyTo(array3,10);

            foreach(int item in array3)
            {
                Console.Write(item + "-");
            }












        }
    }
}
