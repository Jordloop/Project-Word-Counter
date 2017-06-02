using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class CountRepeatsTest
  {

    [Fact]
    public void CheckEquality_CountRepeats()
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
    
  }
}
