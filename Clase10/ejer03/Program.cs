using System;
using System.Collections.Generic;


namespace ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<string> nodo1= new LinkedListNode<string>("Nicolas");
            LinkedListNode<string> nodo2= new LinkedListNode<string>("pedro");
            LinkedListNode<string> nodo3= new LinkedListNode<string>("Cecilia");
            LinkedListNode<string> nodo4= new LinkedListNode<string>("Alberto");

            LinkedListNode<string> nodo5= new LinkedListNode<string>("Maxi");
            
            LinkedList<string> nombres=new LinkedList<string>();

            nombres.AddFirst(nodo1);
            nombres.AddAfter(nodo1,nodo2);
            nombres.AddAfter(nodo2,nodo3);
            nombres.AddAfter(nodo3,nodo4);
            nombres.AddLast(nodo5);


            nombres.RemoveLast();    

            while(nodo1!=null)
            {
              Console.WriteLine(nodo1.Value);
              nodo1=nodo1.Next;
            }
          




        }
    }
}
