using System;
using System.Collections.Generic;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> Fila = new Queue<String>();
            //Enfileirando

            Fila.Enqueue("A");
            Fila.Enqueue("B");
            Fila.Enqueue("C");
            Fila.Enqueue("D");
            Fila.Enqueue("E");

            //Removendo da Fila
            Fila.Dequeue();

            foreach (String x in Fila)
            {
                Console.WriteLine(x);

            }
            Console.WriteLine("Mostrando o primeiro da Fila");
            Console.WriteLine(Fila.Peek());
            Console.ReadKey();

           
        }
    }
}
