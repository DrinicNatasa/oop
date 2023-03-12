using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230312Liste
{
    class List<T>
    {
        //List<int> lista = new List<int>();
        private Node<T> head;
        private Node<T> tail;


        public void Add(T info)      //za dvostruko povezanu listu
        {
            Node<T> clan = new Node<T>();
            clan.info = info;
            clan.next = null;

            if (head == null)
            {
                head = clan;
                tail = clan;
                return;
            }
            tail.next = clan;
            tail = clan;
        }

        public override string ToString()
        {
            if(head == null)
            {
                return "empty";
            }
            Node<T> temp = head;
            StringBuilder str = new StringBuilder(); //da ne bismo pravili nepotrebne stringove, sa casa
            while(temp != null)
            {
                str.Append(temp.info);
                temp = temp.next;
            }
            return str.ToString();
        }

        public void Count(List<T> lista) //?????????????
        {
            
        }

        public void InsertAt(int index)
        {
            Node<T> clan = new Node<T>();
            clan.info = info;
            if(index < lista.Count)
            {
                if (head == null)
                {
                    head = clan;
                }

            }
            else
            {
                Console.WriteLine($"{index}. clan ne postoji");
            }
            
        }
    }

}
