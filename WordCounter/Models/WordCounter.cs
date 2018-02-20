using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;


        public RepeatCounter (string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public int CountWords()
        {
            int count = 0;
            string sentence = _sentence.ToLower();
            string word = _word.ToLower();

            string [] inputSentence = sentence.Split();

            for (int index = 0; index < inputSentence.Length; index++)
            {
                if(inputSentence[index] == word)
                {
                    count +=1;
                }
            }
            return count;
        }

    }
}
