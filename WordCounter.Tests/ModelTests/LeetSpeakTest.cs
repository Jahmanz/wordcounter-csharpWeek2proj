using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;

namespace WordCounterApp.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void GetPhrase_ReturnWord_String()
    {
      string TestPhrase =  "1";
      string preConvertedPhrase = "A";
      string ConvertedPhrase = WordCounter.WordTranslate(preConvertedPhrase);
      Assert.AreEqual(TestPhrase, ConvertedPhrase);
    }
  }
}
