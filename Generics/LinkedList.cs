using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    public class LinkedList<T> : ICollection<T>
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Count { get; private set; } = 0;

        public bool IsReadOnly => throw new NotImplementedException();

        public int Add(T item)
        {
            Node temp = new Node(item);
            if (Head == null)
            {
                Head = Tail = temp;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
            }
            Count++;
            return Count;
        }

        public bool Remove(T item)
        {
            if (Head == null)
            {
                return false;
            }
            if (Head.Value.Equals(item))
            {
                Head = Head.Next;
                Count--;
                return true;
            }
            Node temp = Head;
            while (temp.Next != null)
            {
                if (temp.Next.Value.Equals(item))
                {
                    temp.Next = temp.Next.Next;
                    Count--;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public bool Check(T item)
        {
            if (Head == null)
            {
                return false;
            }
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Value.Equals(item))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public int Index(T item)
        {
            int index = 0;
            if (Head == null)
            {
                return -1;
            }
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Value.Equals(item))
                {
                    return index;
                }
                index++;
                temp = temp.Next;
            }
            return -1;
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
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        public class Node
        {
            public T Value { get; set; }
            internal Node Next { get; set; }

            internal Node(T val)
            {
                Value = val;
                Next = null;
            }
        }

        private class Enumerator : IEnumerator<T>
        {
            private readonly LinkedList<T> _linkedList;

            private int _index;

            private Node _currentNode;

            public Enumerator(LinkedList<T> list)
            {
                _linkedList = list;
                _index = list.Count;
                _currentNode = list.Head;
            }

            public T Current
            {
                get
                {
                    if (_index < 0)
                    {
                        throw new InvalidOperationException("Enumerator has ended");
                    }
                    T current = _currentNode.Value;
                    _currentNode = _currentNode.Next;
                    return current;
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                _index = -1;
            }

            public bool MoveNext()
            {
                _index -= 1;
                // End of enumeration.
                if (_index < 0)
                {
                    return false;
                }
                else
                    return true;
            }

            public void Reset()
            {
                _index = _linkedList.Count;
            }
        }
    }
}
