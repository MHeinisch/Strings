using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class SystemString : ICustomString
    {

        //member variables
        string stringToUse;



        //constructor
        public SystemString(string StringToUse)
        {
            stringToUse = StringToUse;
        }



        //functions
        public override string ToString()
        {
            return stringToUse;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            stringToUse += stringToInsert;
        }

        public  void Remove(int startIndex, int numCharsToRemove)
        {
            stringToUse.Remove(startIndex, numCharsToRemove);
        }

        public int Length()
        {
            return stringToUse.Length;
        }

    }
}
