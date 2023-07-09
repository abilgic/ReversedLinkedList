using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedLinkedList
{
    internal class LinkedList
    {
        public Node Root;
        public class Node
        {
            public int Data;
            public Node Next;
            public Node(int Data)
            {
                this.Data = Data;
            }
        }
        public Node Insert(int Data, Node Head)
        {
            if (Head == null)
            {
                Head = new Node(Data);
                return Head;
            }
            else
            {
                Head.Next = Insert(Data, Head.Next);
                return Head;
            }

        }
        public void Print(Node Head)
        {
            if (Head == null)
                return;
            Console.Write($"{Head.Data} ");
            Print(Head.Next);
        }
    }
}
