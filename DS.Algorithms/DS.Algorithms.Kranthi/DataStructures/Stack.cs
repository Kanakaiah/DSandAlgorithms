using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Kranthi.DataStructures
{
    class Stack <T>
    {
        const int INITIAL_ARRAY_SIZE = 2;
        private T[] holder;
        private int top;

        /// <summary>
        /// Constructor that initializes Stack and Top
        /// </summary>
        public Stack()
        {
            holder = new T[INITIAL_ARRAY_SIZE];
            top = 0;
        }

        /// <summary>
        /// This method inserts an element to Stack
        /// </summary>
        /// <param name="element">Element to be inserted</param>
        internal void Push(T element)
        {
            if (top >= holder.Length)
            {
                Array.Resize(ref holder, holder.Length * 2);
            }
            holder[top++] = element;
        }

        /// <summary>
        /// This methods deletes top most element from Stack
        /// </summary>
        /// <returns>Deleted element</returns>
        internal T Pop()
        {
            if (top == 0)
                throw new InvalidOperationException("Stack is Empty");

            T topValue = holder[--top];

            holder[top] = default(T);
            return topValue;
        }

        /// <summary>
        /// This methods returns top most element of Stack
        /// </summary>
        /// <returns>Top element</returns>
        internal T Peek()
        {
            if (top == 0)
                throw new InvalidOperationException("Stack is Empty");

            return holder[top - 1];
        }

        /// <summary>
        /// This method checks if the given element is present in Stack
        /// </summary>
        /// <param name="element">Element to be searched</param>
        /// <returns>True, if element is present in Stack
        /// False, Otherwise</returns>
        internal bool Contains(T element)
        {
            /*for (int index = 0; index < stack.Length; index++)
            {
                if (stack[index].Equals(element))
                    return true;
            }
            return false;*/
                        
            if (holder.Contains(element))
                return true;

            return false;
        }
    }
}
