
using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userWord;
    private string _userSentence;
    private int _wordCount ;
//CLASS CONSTRUCTOR
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

//  THIS METHOD LOOPS THROUGH userSentence SEARCHINBG FOR userWord THEN RETURNS NUMBER OF TIMES userWord IS PRESENT IN userSentence.
    public int CountRepeats(string userWord, string userSentence)
    {
      //  LOCAL VARIABLES
      string tempString;
      int result = 0;
      char[] charToTrim = {'!', '.', '?', ',', ';', ':'}; //  CHARACTERS THAT I DO NOT WANT TO BE PRESENT WHEN CHECKING EQUALITY.
      string userWordToLower = userWord.ToLower(); // CONVERTS userWord TO LOWER CASE.
      string userSentenceToLower = userSentence.ToLower(); // CONVERTS userSentence TO LOWER CASE.
      string[] userSentenceToArray = userSentenceToLower.Split(' ');  // CREATES AN ARRAY WHERE EACH (STRING)ELEMENT IS A SINGLE WORD FROM userSentence.

      //  LOGIC
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
