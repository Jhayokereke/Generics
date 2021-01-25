using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Queue<T>: ICollection<T>
    {
        private Node Head;

        private Node Tail;
        public int Count { get; private set; } = 0;

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enqueue(T item)
        {
            Node temp = new Node(item);
            if (Tail == null)
            {
                Head = Tail = temp;
                Count++;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
                Count++;
            }
        }

        public T Dequeue()
        {
            if (Head == null)
            {
                throw new NullReferenceException("This is an empty queue");
            }
            else
            {
                Node temp = Head;
                Head = Head.Next;
                Count--;
                return temp.Value;
            }
        }

        public int Size()
        {
            return Count;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class Node
        {
            public T Value;
            public Node Next;

            public Node(T val)
            {
                Value = val;
                Next = null;
            }
        }
    }
}
