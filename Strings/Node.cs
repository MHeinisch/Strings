using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Node
    {

        //member variables
        public char letter;
        public Node next;        



        //constructor
        public Node(char Letter)
        {
            letter = Letter;
            next = null;
        }



        //functions
        public Node CreateCustomLinkedList (List<char> charsList)
        {
            Node head = new Node(charsList[0]);
            Node last = head;
            for (int i = 1; i < charsList.Count(); i++)
            {
                last.next = new Node(charsList[i]);
                last = last.next;
            }            
            return head;
        }
    }
}
