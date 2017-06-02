
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
      int result = 0;
      string userWordToLower = userWord.ToLower();
      string userSentenceToLower = userSentence.ToLower();

      if (userWordToLower == userSentenceToLower)
      {
        result += 1;
      }
      else
      {
        result += 0;
      }
      return result;
    }
  }
}
