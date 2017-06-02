
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userWord;
    private string _userSentence;
    private int _wordCount ;

    public RepeatCounter(string word, string sentence)
    {
      _userWord = word;
      _userSentence = sentence;
      _wordCount = 0;
    }
//  CLASS SETTER
    public void SetWordCount(int newWordCount)
    {
      _wordCount = newWordCount;
    }

// CLASS GETTERS
    public string GetUserWord()
    {
      return _userWord;
    }

    public string GetUserSentence()
    {
      return _userSentence;
    }

    public int GetWordCount()
    {
      return _wordCount;
    }

//  THIS METHOD LOOKS THROUGH userSentence FOR userWord RETURNS NUMBER OF TIMES IT IS PRESENT.
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
