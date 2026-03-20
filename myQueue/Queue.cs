using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueManuzzato
{
    internal class Queue<T> : IQueue<T>
    {
        private Node<T>? head;

        public int Count;

        public Queue()
        {
            head = null;
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }

        public T Dequeue()
        {
            if (head == null)
                throw new Exception("lista non valorizzata");

            T value = head.Data;

            if (head.Next == null)
                head = null;
            else
                head = head.Next;

            Count--;

            return value;
        }

        public void Enqueue(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                Count++;
                return;
            }

            Node<T> node = head;

            while (node.Next != null)
                node = node.Next;

            node.Next = new Node<T>(item);

            Count++;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T Peek()
        {
            if (head == null)
                throw new Exception("Lista non valorizzata");

            return head.Data;
        }
    }
}
