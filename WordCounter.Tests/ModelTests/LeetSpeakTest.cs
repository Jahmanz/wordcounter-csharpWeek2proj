using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {

    [TestMethod]
    public void CountRepeatedWord_ReturnOneLetter_One()
    {

      string inputtedPhrase = "a";
      string inputtedWord = "a";
      RepeatCounter testInputtedPhrase = new RepeatCounter(inputtedPhrase, inputtedWord);


      int expectedOutput = RepeatCounter.CountRepeatedWord(inputtedPhrase, inputtedWord);


      Assert.AreEqual(1, expectedOutput);
    }
  }
}
