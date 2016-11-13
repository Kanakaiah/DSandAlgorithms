using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.ShashiPriya
{
    class MyQueue
    {
        public  class QueueNode
        {
            public int Data;
            public QueueNode Next;

            public QueueNode(int d)
            {
                this.Data = d;
            }
        }

        public QueueNode front;
        public QueueNode rear;

        public void EnQueue(int d)
        {
            QueueNode q = new QueueNode(d);
            if (rear != null)
                rear.Next = q;
            rear = q;
            if (front == null)
                front = rear;
        }

        public void  DeQueue()
        {
            if(front==null)
                Console.WriteLine("Queue is empty");
            else
            {
                int data = front.Data;
                front = front.Next;
                if (front == null)
                    rear = null;
                Console.WriteLine("Element removed is "+data);
            }
        }
    }
}
