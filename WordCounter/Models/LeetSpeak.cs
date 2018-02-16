using System;
using System.Collections.Generic;

namespace WordCounterApp.Models
{
  public class WordCounter
  {
    public static string WordTranslate(string inputPhrase)
    {
      string translatedPhrase = inputPhrase.Replace("A", "1");
      return translatedPhrase;
    }
  }
}
