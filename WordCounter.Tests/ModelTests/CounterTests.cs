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
    public void CountWord_ReturnOneLetter_1()
    {

      string inputPhrase = "a";
      string inputWord = "a";
      RepeatCounter testInputPhrase = new RepeatCounter(inputPhrase, inputWord);
      int expectedOutput = RepeatCounter.CountWord(inputPhrase, inputWord);
      Assert.AreEqual(1, expectedOutput);
    }
    [TestMethod]
    public void CountWord_ReturnWordCount_1()
    {

      string inputPhrase = "jahmanz";
      string inputWord = "jahmanz";
      RepeatCounter testInputPhrase = new RepeatCounter(inputPhrase, inputWord);
      int expectedOutput = RepeatCounter.CountWord(inputPhrase, inputWord);
      Assert.AreEqual(1, expectedOutput);
    }

    [TestMethod]
    public void CountWord_ReturnWordCountMulipleWords_2()
    {

      string inputPhrase = "jahmanz is jahmanz";
      string inputWord = "jahmanz";
      RepeatCounter testInputPhrase = new RepeatCounter(inputPhrase, inputWord);
      int expectedOutput = RepeatCounter.CountWord(inputPhrase, inputWord);
      Assert.AreEqual(2, expectedOutput);
    }
    [TestMethod]
    public void CountWord_ReturnWordCountMulipleWordsWithPunctuation_2()
    {

      string inputPhrase = "jahmanz is jahmanz!";
      string inputWord = "jahmanz";
      RepeatCounter testInputPhrase = new RepeatCounter(inputPhrase, inputWord);
      int expectedOutput = RepeatCounter.CountWord(inputPhrase, inputWord);
      Assert.AreEqual(2, expectedOutput);
    }

    [TestMethod]
    public void CountWord_ReturnWordCountCompletePhrase_3()
    {

      string inputPhrase = "In the beggining, the man, and the dog were friends.";
      string inputWord = "the";
      RepeatCounter testInputPhrase = new RepeatCounter(inputPhrase, inputWord);
      int expectedOutput = RepeatCounter.CountWord(inputPhrase, inputWord);
      Assert.AreEqual(3, expectedOutput);
    }
  }
}
