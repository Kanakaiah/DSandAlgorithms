using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish
{
    public class MyStack<T> : IEnumerator<T>
    {
        // string [] myBible = new string[10];
          List<T> stack = new List<T>();
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


        //  string popString;

        public MyStack()
        {
            Index = 0;
            Size = 0;
            
        }

       

        public T Get(int index)
        {
            return stack[index];
        }

        public void push(T entryValue)
        {
            // myBible[Index] = str1;
            stack.Add(entryValue);
                            
            Index = Index + 1;
            Size = Size + 1;
        }

        public T pop()
        {
            // popString = myBible[Index - 1];
            T popValue;
            popValue = stack[Index - 1];
            stack.Remove(popValue);
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
    }
}
