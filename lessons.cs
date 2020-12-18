using System;
using System.Collections.Generic;

namespace Level1Space
{
  public static class Level1
  {
      public static int SumOfThe(int N, int[] data)
        {
            int result=0;
            
            for (int i = 0; i<N; i++)
            {
                int summ = 0;
                for (int j=0; j<N; j++)
                {
                    if(j!=i)
                    summ = summ + data[j];
                }
                if (data[i]==summ)
                {
                    result = summ;
                    break;
                }
            }
            return result;
        }
  }
}
