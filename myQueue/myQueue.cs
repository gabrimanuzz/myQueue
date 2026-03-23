using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQueue
{
    public class myQueue<T> : IQueue<T>
    {
        private Node<T>? head;

        public int Count { get; private set; }

        public myQueue()
        {
            head = null;
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }

        public virtual T Dequeue()
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

        public virtual void Enqueue(T item)
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

        public virtual T Peek()
        {
            if (head == null)
                throw new Exception("Lista non valorizzata");

            return head.Data;
        }
    }
}
