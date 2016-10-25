using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.ShashiPriya
{
    class MyStack                        // Stack follows LIFO . There will be a need of only one pointer for insertion and deletion .Implementing with Stack, complexity is O(1) as we are using only top.
    {
        public class StackNode         // LL will have data and next . We will use top pointer for inserting and deleting. 
        {
            public int data;            

            public StackNode next;

            public StackNode(int d)
            {
                this.data = d;
            }
        }

        public StackNode top;


        // Inserting an element.
        // new node will be on the top of the old node and it should have the address of the old element in its next. Top now should point to the new node.
        public void push(int item)
        {
            StackNode n = new StackNode(item);
            n.next = top;
            top = n;
        }

        public int pop()
        {
         
            if (isEmpty()) throw new EmptyStackException();

            int value = top.data;
            top = top.next;
            return value;

        }

        public bool isEmpty()
        {
            bool result = false;
            if (top == null) result = true;
            return result;
        }

        public int Top()
        {
            if (isEmpty()) throw new EmptyStackException();

            return top.data;
           
            
        }
        public class EmptyStackException :Exception
        {
            public EmptyStackException()
            {

            }
            public EmptyStackException(string message) :base(message)
            {

            }
        }



    }
}
