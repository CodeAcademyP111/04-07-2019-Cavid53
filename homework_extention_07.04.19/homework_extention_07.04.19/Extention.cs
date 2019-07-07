using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_extention_07._04._19
{
     public static class Extention
    {
        //exercise-1
        #region extention for find simple number
        //public static string SimpleNumber( this int num)
        //  {
        //      int n = 0;
        //      for (int i = 1; i <= num; i++)
        //      {
        //          if (num % i == 0)
        //          {
        //              n++;
        //          }
        //      }

        //      if (n == 2)
        //      {
        //          return $"This is simple number";
        //      }
        //      else
        //      {
        //          return $"This is  not simple number";
        //      }
        //  }
        #endregion


            //exercise-2
        public static int FindMyIndexOf( this string word1,char a)
        {
            int n = -1;
            for (int i = 0; i < word1.Length; i++)

            {
                if (word1[i] == a) 
                {
                    n = i;
                }
            }
            return n;
        }
    }
}
