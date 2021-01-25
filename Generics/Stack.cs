using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Stack<T> : ICollection<T>
    {
        public Node Head { get; set; }
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

        public void Push(T item)
        {
            if (Head == null)
            {
                Head = new Node(item);
                Count++;
            }
            else
            {
                Node temp = new Node(item);
                temp.Next = Head;
                Head = temp;
                Count++;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException("You are attempting to return a null value");
            }
            else
            {
                return Head.Value;
            }
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException("You are attempting to remove a null value");
            }
            else
            {
                Head = Head.Next;
                Count--;
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
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T val)
            {
                Value = val;
                Next = null;
            }
        }
    }
}
