using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Queue<T>: ICollection<T>
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

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
            return new Enumerator(this);
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
            internal Node Next { get; set; }

            internal Node(T val)
            {
                Value = val;
                Next = null;
            }
        }

        private class Enumerator : IEnumerator<T>
        {
            private readonly Queue<T> _queue;

            private int _index;

            private Node _currentNode;

            public Enumerator(Queue<T> queue)
            {
                _queue = queue;
                _index = queue.Count;
                _currentNode = queue.Head;
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
                _index = _queue.Count;
            }
        }
    }
}
