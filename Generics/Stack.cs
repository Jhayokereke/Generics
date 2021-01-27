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

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException("You are attempting to remove a null value");
            }
            else
            {
                T val = Head.Value;
                Head = Head.Next;
                Count--;
                return val;
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
            private readonly Stack<T> _stack;

            private int _index;

            private Node _currentNode;

            public Enumerator(Stack<T> stack)
            {
                _stack = stack;
                _index = stack.Count;
                _currentNode = stack.Head;
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
                _index = _stack.Count;
            }
        }
    }
}
