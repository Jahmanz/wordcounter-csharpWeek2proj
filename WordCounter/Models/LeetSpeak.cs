using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
    private int _count;

    public RepeatCounter (string sentence, string word, int count = 0)
    {
      _sentence = sentence;
      _word = word;
      _count = count;
    }

    public static int CountWord(string sentence, string word)
    {
      string [] userPhrase = sentence.ToLower().Split(new Char [] {' ','.', ',','!','?',});

      int count = 0;

      foreach (string currentWord in userPhrase)
      {
        if (currentWord == word.ToLower())
        {
          count++;
        }
      }
      return count;
    }
  }
}
