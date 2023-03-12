using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230312Liste
{
    class Node<T>
    {
        public T info;
        public Node<T> next;
        public Node<T> prev;

        public override string ToString()
        {
            return info.ToString();
        }
    }
}
