using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3 {
    public class CustomQueue<T> : IEnumerable<T> {
        private T[] _array;
        private int _head;
        private int _tail;

        private int Capacity
        {
            get { return _array.Length; }
        }

        public int Count { get; private set; }

        public CustomQueue() {
            _array = new T[16];
            _head = 0;
            _tail = 0;
            Count = 0;
        }

        public void Enqueue(T obj) {
            if (Count == Capacity) {
                Increace();
            }
            _array[_tail] = obj;
            _tail = (_tail + 1)%Capacity;
            Count = Count + 1;
        }

        public T Dequeue() {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            T obj = _array[_head];
            _head = (_head + 1)%Capacity;
            Count = Count - 1;
            return obj;
        }

        public T Peek() {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            return _array[_head];
        }



        public IEnumerator<T> GetEnumerator() {
            return new QueueEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return new QueueEnumerator(this);
        }


        private struct QueueEnumerator : IEnumerator<T> {
            private CustomQueue<T> _q;
            private int _index;
            private T _currentElement;

            public T Current
            {
                get
                {
                    if (_index < 0) {
                        if (_index == -1)
                            throw new InvalidOperationException("Enum not started.");
                        else
                            throw new InvalidOperationException("Enum ended.");
                    }
                    return _currentElement;
                }
            }

            object IEnumerator.Current => Current;

            internal QueueEnumerator(CustomQueue<T> q) {
                _q = q;
                _index = -1;
                _currentElement = default(T);
            }

            public void Dispose() {
                _index = -2;
                _currentElement = default(T);
            }

            public bool MoveNext() {
                if (_index == -2)
                    return false;
                _index = _index + 1;
                if (_index == _q.Count) {
                    _index = -2;
                    _currentElement = default(T);
                    return false;
                }
                _currentElement = _q.GetElement(_index);
                return true;
            }

            void IEnumerator.Reset() {
                _index = -1;
                _currentElement = default(T);
            }

        }
        private T GetElement(int i) {
            return _array[(_head + i) % _array.Length];
        }
        private void Increace() {
            T[] temp = new T[Capacity * 2];
            int currLength = Count;
            for (int i = 0; i < currLength; i++)
                temp[i] = Dequeue();
            _head = 0;
            _tail = currLength;
            Count = currLength;
            _array = temp;
        }
    }
}
