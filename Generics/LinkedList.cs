using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    public class LinkedList<T> : ICollection<T>
    {
        private Node Head { get; set; }
        private Node Tail { get; set; }

        public int Count { get; private set; } = 0;

        public bool IsReadOnly => throw new NotImplementedException();

        public int Add(T item)
        {
            Node temp = new Node(item);
            if (Head == null)
            {
                Head = Tail = temp;
                Count++;
                return Count;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
                Count++;
                return Count;
            }
        }

        public bool Remove(T item)
        {
            if (Head == null)
            {
                return false;
            }
            else if (Head.Value.Equals(item))
            {
                Head = Head.Next;
                Count--;
                return true;
            }
            else
            {
                bool done = Head.RemoveNext(item);
                if (done == true)
                {
                    Count--;
                }
                return done;
            }
        }

        public bool Check(T item)
        {
            if (Head == null)
            {
                return false;
            }
            else if (Head.Value.Equals(item))
            {
                return true;
            }
            else
            {
                return Head.CheckNext(item);
            }
        }

        public int Index(T item)
        {
            int index = 0;
            if (Head == null)
            {
                return -1;
            }
            else if (Head.Value.Equals(item))
            {
                return index;
            }
            else
            {
                index += Head.IndexOfNext(index, item);
                return index;
            }
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

        internal class Node
        {
            internal T Value { get; set; }
            internal Node Next { get; set; }

            internal Node(T val)
            {
                Value = val;
                Next = null;
            }

            internal bool RemoveNext(T val)
            {
                if (Next == null)
                {
                    return false;
                }
                else if (Next.Value.Equals(val))
                {
                    var temp = Next;
                    this.Next = temp.Next;
                    return true;
                }
                else
                {
                    return Next.RemoveNext(val);
                }
            }

            internal bool CheckNext(T val)
            {
                if (Next == null)
                {
                    return false;
                }
                else if (Next.Value.Equals(val))
                {
                    return true;
                }
                else
                {
                    return Next.CheckNext(val);
                }
            }

            internal int IndexOfNext(int prevIndex, T val)
            {
                int index = prevIndex+1;
                if (Next == null)
                {
                    return -1;
                }
                else if (Next.Value.Equals(val))
                {
                    return index;
                }
                else
                {
                    return Next.IndexOfNext(index, val);
                }
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
