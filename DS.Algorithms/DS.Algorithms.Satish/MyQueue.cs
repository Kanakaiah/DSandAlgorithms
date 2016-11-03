using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish
{
    class MyQueue<T> : IEnumerator<T>
    {

        List<T> queue = new List<T>();
        public int Index { get; set; }
        public int Size { get; set; }

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }




        //  string popString;

        public MyQueue()
        {
            Index = 0;
            Size = 0;

        }



        public T Get(int index)
        {
            return queue[index];
        }

        public void enqueue(T entryValue)
        {
            // myBible[Index] = str1;
            queue.Add(entryValue);

            Index = Index + 1;
            Size = Size + 1;
        }

        public T dequeue()
        {
            // popString = myBible[Index - 1];
            T popValue;
            popValue = queue[0];
            queue.Remove(popValue);
            Index = Index - 1;
            Size = Size - 1;
            return popValue;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}

