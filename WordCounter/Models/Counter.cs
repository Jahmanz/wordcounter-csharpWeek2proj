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

      foreach (string newPhrase in userPhrase)
      {
        if (newPhrase == word.ToLower())
        {
          count++;
        }
      }
      return count;
    }
    public string GetSentence
    {
      return _sentence
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence
    }
    public string GetWord
    {
      return _word
    }
    public void SetWord(string newWord)
    {
      _word = newWord
    }
  }
}
