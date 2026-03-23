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
        private Node<T>? tail;

        public int Count { get; private set; }

        public myQueue()
        {
            head = null;
            tail = null;
        }

        public void Clear()
        {
            head = null;
            Count = 0;
            tail = null;
        }

        public virtual T Dequeue()
        {
            if (head == null)
                throw new Exception("lista non valorizzata");

            T value = head.Data;

            head = head.Next;
            if (head == null)
                tail = null;

            Count--;

            return value;
        }

        public virtual void Enqueue(T item)
        {
            var newNode = new Node<T>(item);
            
            if (head == null)
                head = tail = newNode;
            else
            {
                tail!.Next = newNode;
                tail = newNode;
            }

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
