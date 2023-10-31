using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglylLinkedList
{
     public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            SingleLinkedList list = new SingleLinkedList();
            int i = 0;
            while (i <= 10)
            {
                list.Add(i);
                i++;
            }
               
            // Get and print the length of the linked list

                list.Display();
                
            
        }
    }
}

