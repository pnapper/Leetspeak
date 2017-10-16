using System.Collections.Generic;
using System;

namespace Leetspeak.Models
{
  public class LeetspeakGenerator
  {
    public List<string> GetResult(string word)
    {
      List<string> letterList = new List<string> {};
      List<string> resultList = new List<string> {};

      char[] letter = word.ToCharArray();

      for (int i = 0; i < letter.Length; i++)
      {
        if( letter[i] == 'e' || letter[i] == 'E')
        {
          letter[i] = '3';
        }
        else if(letter[i] == 'o' || letter[i] == 'O')
        {
          letter[i] = '0';
        }
        else if(letter[i] == 't' || letter[i] == 'T')
        {
          letter[i] = '7';
        }
        else if(letter[i] == 'I')
        {
          letter[i] = '1';
        }
        else if((letter[i] == 's' && i != 0)|| (letter[i] == 'S' && i !=0))
        {
          letter[i] = 'z';
        }
      }
      string result = string.Join("", letter);
      resultList.Add(result);

      return resultList;
    }
  }
}
