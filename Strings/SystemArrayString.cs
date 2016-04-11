using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class SystemArrayString : ICustomString
    {

        //member variables
        public char[] charArray;



        //constructor
        public SystemArrayString(string stringToUse)
        {
            charArray = stringToUse.ToCharArray();
        }



        //functions
        public override string ToString()
        {
            string charToString = "";
            for (int i = 0; i < charArray.Count(); i++)
            {
                charToString += charArray[i];
            }
            return charToString;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            string charArrayToString = "";
            for (int i = 0; i < charArray.Count(); i++)
            {
                if (i != startIndex)
                {
                    charArrayToString += charArray[i];
                }
                else
                {
                    charArrayToString += stringToInsert;
                    charArrayToString += charArray[i];
                }
            }
            charArray = charArrayToString.ToArray();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int numberOfIndices = charArray.Length;
            int newArrayIndexCounter = 0;
            for (int charArrayIndex = startIndex; charArrayIndex < startIndex + numCharsToRemove; charArrayIndex++)
            {
                charArray[charArrayIndex] = '\0';
                numberOfIndices--;
            }
            char[] newCharArray = new char[numberOfIndices];
            for(int charArrayIndex = 0; charArrayIndex < charArray.Length; charArrayIndex++)
            {
                if (charArray[charArrayIndex] != '\0')
                {
                    newCharArray[newArrayIndexCounter] = charArray[charArrayIndex];
                    newArrayIndexCounter++;
                }
            }
            charArray = newCharArray;           
        }

        public int Length()
        {
            return charArray.Length;
        }

    }
}
