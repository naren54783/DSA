using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace DSA
{
    public static class Misc1
    {

     

   


      

        public static int isPalindrome(string A)
        {

            if (A == "") return 0;
            int startIndex = 0;
            int endIndex = A.Length-1;

            while (startIndex < endIndex)
            {

                if (!checkIfAlphanumeric(A[startIndex]))
                {
                    startIndex++;
                }
                else if (!checkIfAlphanumeric(A[endIndex]))
                {
                    endIndex--;
                }
                else
                {

                    if (A[startIndex].ToString().ToUpper() != A[endIndex].ToString().ToUpper())
                    {
                        return 0;
                    }
                    startIndex++;
                    endIndex--;
                }
              

            }

            return 1;

        }

        static bool  checkIfAlphanumeric(char ch)
        {
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
                {
                return true;
            }
            return false;
        }

    
    }
}
