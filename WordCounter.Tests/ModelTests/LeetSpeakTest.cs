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
    public void CountWord_ReturnOneLetter_One()
    {

      string inputPhrase = "a";
      string inputWord = "a";
      RepeatCounter testInputPhrase = new RepeatCounter(inputPhrase, inputWord);


      int expectedOutput = RepeatCounter.CountWord(inputPhrase, inputWord);


      Assert.AreEqual(1, expectedOutput);
    }
      [TestMethod]
      public void CountWord_ReturnWordCount_One()
      {

        string inputPhrase = "jahmanz";
        string inputWord = "jahmanz";
        RepeatCounter testInputPhrase = new RepeatCounter(inputPhrase, inputWord);


        int expectedOutput = RepeatCounter.CountWord(inputPhrase, inputWord);


        Assert.AreEqual(1, expectedOutput);
    }
  }
}
