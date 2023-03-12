using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _230312Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> nekiBroj = new Node<int>();
            nekiBroj.info = 5;
            Console.WriteLine(nekiBroj);
            Node<string> nekiString = new Node<string>();
            nekiString.info = "Danas je nedelja";
            Console.WriteLine(nekiString);
            Console.WriteLine("**********");

            List<int> lista = new List<int>();
            Console.WriteLine(lista);
            lista.Add(3);
            lista.Add(8);
            lista.Add(6);
            Console.WriteLine(lista);
            /*ReadOnlyCollection<int> readOnlyLista = new ReadOnlyCollection<int>(lista);

            Console.WriteLine();
            foreach (int clan in readOnlyLista)
            {
                Console.WriteLine(clan);
            }

            Console.WriteLine("\nCount: {0}", readOnlyLista.Count);*/



        }
    }
}
