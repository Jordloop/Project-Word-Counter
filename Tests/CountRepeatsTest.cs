using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class CountRepeatsTest
  {

    [Fact]
    public void CountRepeats_CheckEqualityCaseSensitive_True()
    {
      //ARRANGE
      int expectedResult = 1;
      string testWord = "Foo";
      string testSentence = "Foo";
      RepeatCounter newCount = new RepeatCounter(testWord, testSentence);
      //ACT
      int result = newCount.CountRepeats(testWord, testSentence);
      //ASSERT
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_CheckEqualityNotCaseSensitive_True()
    {
      //ARRANGE
      int expectedResult = 1;
      string testWord = "Foo";
      string testSentence = "fOO";
      RepeatCounter newCount = new RepeatCounter(testWord, testSentence);
      //ACT
      int result = newCount.CountRepeats(testWord, testSentence);
      //ASSERT
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_FindEqualityInMultiWordString_True()
    {
      //ARRANGE
      int expectedResult = 1;
      string testWord = "foo";
      string testSentence = "The word foo is not the word food.";
      RepeatCounter newCount = new RepeatCounter(testWord, testSentence);
      //ACT
      int result = newCount.CountRepeats(testWord, testSentence);
      //ASSERT
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_FindEqualityWithPunctuation_True()
    {
      //ARRANGE
      int expectedResult = 1;
      string testWord = "foo";
      string testSentence = "Why do I keep typing foo?";
      RepeatCounter newCount = new RepeatCounter(testWord, testSentence);
      //ACT
      int result = newCount.CountRepeats(testWord, testSentence);
      //ASSERT
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_FindEachEqualityInMultiWordString_True()
    {
      //ARRANGE
      int expectedResult = 2;
      string testWord = "foo";
      string testSentence = "Foo, why do I keep typing foo?";
      RepeatCounter newCount = new RepeatCounter(testWord, testSentence);
      //ACT
      int result = newCount.CountRepeats(testWord, testSentence);
      //ASSERT
      Assert.Equal(expectedResult, result);
    }

  }
}
