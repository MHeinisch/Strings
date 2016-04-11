using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class SystemLinkedListString : ICustomString
    {

        //member variables
        public LinkedList<char> charLinkedList;



        //constructor
        public SystemLinkedListString(string stringToUse)
        {
            char[] temporaryCharArray = stringToUse.ToCharArray();
            charLinkedList = new LinkedList<char>(temporaryCharArray);
        }



        //functions
        public override string ToString()
        {
            string linkedListToString = "";
            for (int i = 0; i < charLinkedList.Count(); i++)
            {
                linkedListToString += charLinkedList.ElementAt<char>(i);
            }
            return linkedListToString;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            string linkedListToString = "";
            char[] charArrayToLinkedList = new char[charLinkedList.Count() + stringToInsert.Length];
            char[] stringToInsertToCharArray = stringToInsert.ToArray();
            int loopUpperBound = charLinkedList.Count();
            for (int i = 0; i < loopUpperBound; i++)
            {
                if (i != startIndex)
                {
                    linkedListToString += charLinkedList.ElementAt<char>(i);
                    charLinkedList.AddLast(charArrayToLinkedList[i]);
                }
                else
                {
                    linkedListToString += stringToInsert;
                    for (int j = 0; j < stringToInsertToCharArray.Length; j++)
                    {
                        charLinkedList.AddLast(stringToInsertToCharArray[j]);
                    }
                    linkedListToString += charLinkedList.ElementAt<char>(i);
                    charLinkedList.AddLast(charArrayToLinkedList[i]);
                }
            }
            char[] temporaryCharArray = linkedListToString.ToCharArray();
            charLinkedList = new LinkedList<char>(temporaryCharArray);
        }


        public void Remove(int startIndex, int numCharsToRemove)
        {
            string linkedListToString = "";
            LinkedListNode<char> firstNode = charLinkedList.First;
            LinkedListNode<char> currentNode = firstNode.Next;
            List<char> stringToListAfterRemove = new List<char>();
            if (startIndex != 0)
            {
                linkedListToString += firstNode.Value;
            }
            int loopUpperBound = charLinkedList.Count();
            for (int i = 1; i < loopUpperBound; i++)
            {
                if (i < startIndex || i > startIndex + numCharsToRemove)
                {
                    LinkedListNode<char> nodeToRemove = currentNode;
                    linkedListToString += currentNode.Value;
                    currentNode = currentNode.Next;
                }
            }
            char[] temporaryCharArray = linkedListToString.ToCharArray();
            charLinkedList = new LinkedList<char>(temporaryCharArray);
        }

        public int Length()
        {
            return charLinkedList.Count();
        }

    }
}
