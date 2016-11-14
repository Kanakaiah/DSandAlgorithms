using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Describe how you could use a single array to implement three stacks
namespace DS.Algorithms.KK.StackQueue
{
    public class SingleArrayToThreeStacks
    {
        static int stackSize = 100;
        static int[] buffer = new int[stackSize * 3];
        static int[] stackPointer = { -1, -1, -1 }; // pointers to track top element

        public static void Push(int stackNum, int value)
        {
            /* Check if we have space */

            if (stackPointer[stackNum] + 1 >= stackSize)
            { // Last element
                throw new Exception("0ut of space.");
            }
            /* Increment stack pointer and then update top value */
            stackPointer[stackNum]++;
            buffer[AbsTopOfStack(stackNum)] = value;
        }

        public static int Pop(int stackNum)
        {
            if (stackPointer[stackNum] == -1)
            {
                throw new Exception("Trying to pop an empty stack.");
            }
            int value = buffer[AbsTopOfStack(stackNum)]; // Get top
            buffer[AbsTopOfStack(stackNum)] = 0; // Clear index
            stackPointer[stackNum]--; // Decrement pointer
            return value;
        }


        public static int Peek(int stackNum)
        {
            int index = AbsTopOfStack(stackNum);
            return buffer[index];
        }

        public static bool IsEmpty(int stackNum)
        {
            return stackPointer[stackNum] == -1;
        }
        /* returns index of top of stack "stackNurrr"J in absolute terms */
        public static int AbsTopOfStack(int stackNum)
        {
            return stackNum * stackSize + stackPointer[stackNum];
        }
    }
}


/*
 
Approach 1: Fixed Division
We can divide the array in three equal parts and allow the individual stack to grow in
that limited space. Note: we will use the notation"[" to mean inclusive of an end point
and"(" to mean exclusive of an end point.
• For stack 1, we will use [0, n/3).
• For stack2,we will use [n/3j 2n/3).
• For stacks, wewill use [2n/3, n).
 
*/