using System;
using System.Collections.Generic;

namespace FindNReplace
{
  public class FindNReplaceProgram
  {
    public string FindAndReplace(string sentence, string original, string newWord)
    {
      string[] sentenceArray = sentence.Split(' ');
      for( int i = 0; i <= sentenceArray.Length-1; i++)
      {
        string wordInLowerCase = sentenceArray[i].ToLower();
        if (wordInLowerCase.Contains(original.ToLower()))
        {
          int index = wordInLowerCase.IndexOf(original.ToLower());
          string slice1 = wordInLowerCase.Substring(0,index);
          string slice2 = wordInLowerCase.Substring(index, index + original.Length);
          string slice3 = wordInLowerCase.Substring(index + original.Length);

          slice2 = newWord;
          sentenceArray[i] = slice1 + slice2 + slice3;
        }
        // if (wordInLowerCase == original.ToLower())
        // {
        //   sentenceArray[i] = newWord;
        // }
      }
      return string.Join(" ", sentenceArray);
    }
  }
}
