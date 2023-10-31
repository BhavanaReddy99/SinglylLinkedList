using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglylLinkedList
{
    public class SingleLinkedList
    {
        public Node Head { get; set; }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public int GetLength()
        {
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }

        public void Display()
        {
            Node current = Head;
            Console.WriteLine("Length of singly linked list = " + GetLength());
            Console.WriteLine("Print Single linked list:");
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }


}
