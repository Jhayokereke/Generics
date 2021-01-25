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
            if (Head == null)
            {
                Head = Tail = new Node(item);
                Count++;
                return Count;
            }
            else
            {
                Node temp = new Node(item);
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
            throw new NotImplementedException();
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
            public Node Next { get; set; }

            public Node(T val)
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
    }
}
