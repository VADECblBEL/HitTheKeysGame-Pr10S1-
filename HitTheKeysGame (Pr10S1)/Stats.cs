using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitTheKeysGame__Pr10S1_
{
  class Stats
  {
    public int Total = 0;
    public int Missed = 0;
    public int Correct = 0;
    public int Accuracy = 0;


    public void Update(bool CorrectKey)
    {
      Total++;
      
      if (!CorrectKey) Missed++;
      else Correct++;

      Accuracy = 100 * Correct / (Missed + Correct);
    }
  }
}
