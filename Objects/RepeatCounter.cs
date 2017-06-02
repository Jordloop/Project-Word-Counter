
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userWord;
    private string _userSentence;

    public RepeatCounter(string word, string sentence)
    {
      _userWord = word;
      _userSentence = sentence;
    }

//  LOOKS THROUGH userSentence FOR userWord RETURNS NUMBER OF TIMES IT IS PRESENT.
    public int CountRepeats(string userWord, string userSentence)
    {
      //LOCAL VARIABLES
      string tempString;
      int result = 0;
      char[] charToTrim = {'!', '.', '?', ',', ';', ':'};
      string userWordToLower = userWord.ToLower();
      string userSentenceToLower = userSentence.ToLower();
      string[] userSentenceToArray = userSentenceToLower.Split(' ');

      for (int i = 0; i < userSentenceToArray.Length; i++)
      {
        tempString = userSentenceToArray[i].Trim(charToTrim);
        if (userWordToLower == tempString)
        {
          result ++;
        }
        else
        {
          result += 0;
        }
      }
      return result;
    }

  }
}
