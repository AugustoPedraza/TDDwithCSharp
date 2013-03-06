using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterOneExample.Utilities
{
    public class StringUtilities
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            var stringAsCharArray = stringToCheck.ToUpper().ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToUpper().ToCharArray()[0];

            var occuranceCount = 0;

            for (var characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0); characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }

            return occuranceCount;
        }
    }
}
