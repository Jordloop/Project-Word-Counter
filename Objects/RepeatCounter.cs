
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

    public int CountRepeats(string userWord, string userSentence)
    {
      //LOCAL VARIABLES
      string tempString;
      int result = 0;
      string userWordToLower = userWord.ToLower();
      string userSentenceToLower = userSentence.ToLower();
      string[] userSentenceToArray = userSentenceToLower.Split(' ');
      char[] charToTrim = {'!', '.', '?', ',', ';', ':'};

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
