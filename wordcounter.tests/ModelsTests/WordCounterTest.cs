using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void CountWord_ReturnOneLetter_1()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("a", "a");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual(1, countWords);
        }
        [TestMethod]
        public void CountWord_ReturnOneWord_1()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("jahmanz", "jahmanz");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual(1, countWords);
        }
        [TestMethod]

        public void CountWord_ReturnWordsInSentence_2()
        {
        RepeatCounter testRepeatCounter = new RepeatCounter("jahmanz", "jahmanz is jahmanz");
        int countWords = testRepeatCounter.CountWords();
        Assert.AreEqual(2, countWords);
        }

    }
}
