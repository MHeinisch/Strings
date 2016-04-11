using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class SortedList
    {

        SystemString newString = new SystemString("Hello World");
        SystemArrayString array = new SystemArrayString("How are you?");
        SystemLinkedListString linkedList = new SystemLinkedListString("I'm doing great!");
        CustomLinkedListString customLL = new CustomLinkedListString("That's good to hear!");

        public SortedList<int, ICustomString> sortedStringList = new SortedList<int, ICustomString>();
        
        public SortedList()
        {
            sortedStringList.Add(customLL.Length(), customLL);
            sortedStringList.Add(array.Length(), array);
            sortedStringList.Add(linkedList.Length(), linkedList);            
            sortedStringList.Add(newString.Length(), newString);
        }

    }
}
