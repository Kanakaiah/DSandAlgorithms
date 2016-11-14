using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.LinkedList
{
    class LinkedList
    {


        public LinkedList()
        {
            Head = Tail = null;
        }

        public Node Head { get; set; }
        public Node Tail { get; set; }


        public void AddNode(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                if(Tail!=null)
                {
                    Tail.Next = node;
                    Tail = Tail.Next;
                }
            }
        }


        //Adds in ascending order.
        public void InsertNode(Node newNode, Node root)
        {
            Node tempNode=null;

            if (newNode == null)
                return;
            if (root == null)
            {
                this.Head = newNode;
                return;
            }

            
            while(root!=null)
            {
                if(newNode.Value>=root.Value)
                {
                    tempNode = root;
                    if (root.Next != null)
                    {
                        root = root.Next;
                    }
                    else
                    {
                        root.Next = newNode;
                        break;
                    }
                }
                else
                {
                    if(tempNode!=null)
                    {
                        tempNode.Next = newNode;
                        newNode.Next = root;
                        break;
                    }
                    else //first node value itself less than the new node value
                    {
                        newNode.Next = root;
                        Head = newNode;
                        break;
                    }
                }
            }
        }
    }
}
