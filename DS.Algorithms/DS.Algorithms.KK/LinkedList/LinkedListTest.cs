using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.LinkedList
{
    public class LinkedListTest
    {
        internal static void RunAddNodes()
        {

            LinkedList linkedList = new LinkedList();

            //linkedList.AddNode((new Node { Value = 1 }));
            //linkedList.AddNode((new Node { Value = 2 }));
            //linkedList.AddNode((new Node { Value = 3 }));
            //linkedList.AddNode((new Node { Value = 5 }));

            Node root = linkedList.Head;

            //while(root!=null)
            //{
            //    Console.Write(root.Value+"-->");
            //    root = root.Next;
            //}


            linkedList.InsertNode((new Node { Value = 0 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 4 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 99 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 156 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 5 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 4 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 6 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 10 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 3 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 1 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 100 }), linkedList.Head);
            linkedList.InsertNode((new Node { Value = 11 }), linkedList.Head);


            root = linkedList.Head;

            Console.WriteLine();

            while (root != null)
            {
                Console.Write(root.Value+"-->");
                root = root.Next;
            }

        }
    }
}
