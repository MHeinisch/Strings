using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class CustomLinkedListString : ICustomString
    {

        //member variables
        Node node = new Node('\n');
        public List<char> stringToList;



        //constructor
        public CustomLinkedListString(string stringToUse)
        {
            stringToList = stringToUse.ToList<char>();
        }



        //functions
        public override string ToString()
        {
            string customLinkedListToString = "";
            Node head = node.CreateCustomLinkedList(stringToList);
            customLinkedListToString += head.letter;
            Node last = head;
            for (int i = 1; i < stringToList.Count(); i++)
            {
                last.next = new Node(stringToList[i]);
                last = last.next;
                customLinkedListToString += last.letter;
            }
            return customLinkedListToString;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            string customLinkedListToString = "";
            List<char> stringToInsertToList = stringToInsert.ToList<char>();
            Node head = node.CreateCustomLinkedList(stringToList);
            customLinkedListToString += head.letter;
            Node last = head;
            for (int i = 1; i < stringToList.Count(); i++)
            {
                if (i != startIndex)
                {
                    last.next = new Node(stringToList[i]);
                    last = last.next;
                    customLinkedListToString += last.letter;
                }
                else
                {
                    for (int j = 0; j < stringToInsert.Length; j++)
                    {
                        last.next = new Node(stringToInsertToList[j]);
                        last = last.next;
                        customLinkedListToString += last.letter;
                    }
                    last.next = new Node(stringToList[i]);
                    last = last.next;
                    customLinkedListToString += last.letter;
                }
            }
            char[] temporaryCharArray = customLinkedListToString.ToCharArray();
            stringToList = new List<char>(temporaryCharArray);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            Node head = node.CreateCustomLinkedList(stringToList);
            Node last = head.next;
            List<char> stringToListAfterRemove = new List<char>();
            if (startIndex != 0)
            {
                stringToListAfterRemove.Add(head.letter);
            }
            for (int i = 1; i < stringToList.Count(); i++)
            {
                if (i < startIndex || i > startIndex + numCharsToRemove)
                {
                    last.next = new Node(stringToList[i]);
                    last = last.next;
                    stringToListAfterRemove.Add(last.letter);
                }
            }
            stringToList = stringToListAfterRemove;
        }


        public int Length()
        {
            return stringToList.Count();
        }
    }
}
