using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeakApp.Models;

namespace LeetSpeakApp.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void GetSentence_ReturnLeet_String()
    {
      string TestSentence =  "7hiz iz L337Sp34k!";
      string preConvertedSentence = "This is LeetSpeak!";
      string ConvertedSentence = LeetSpeak.LeetTranslate(preConvertedSentence);
      Assert.AreEqual(TestSentence, ConvertedSentence);
    }
  }
}
