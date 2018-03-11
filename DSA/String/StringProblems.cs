using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
  public static  class StringProblems
    {
        public static void FindDuplicateCharacters(string str)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (char ch in str)
            {
                if (dic.ContainsKey(ch.ToString()))
                {
                    dic[ch.ToString()] += 1;
                }
                else
                {
                    dic.Add(ch.ToString(), 1);
                }

            }

            //print all duplicate characters
            foreach (var item in dic)
            {
                if (item.Value > 1)
                {

                    Console.WriteLine(item.Key);
                }
            }

            KeyValuePair<string, int> Maxkey = new KeyValuePair<string, int>();
            //print charcter whose occurence is more
            foreach (var item in dic)
            {
                if (item.Value > Maxkey.Value)
                {
                    Maxkey = item;
                }
            }
            Console.WriteLine(Maxkey.Key);
        }

        public static void FindFirstnonRepeatingCharacter(string inputStr)
        {
            //   OrderedDictionary dictionary = new OrderedDictionary();


            Dictionary<string, int> dic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            //  Hashtable<string, int> hashtable = new SortedDictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            string result = "";
            foreach (char ch in inputStr)
            {
                if (dic.ContainsKey(ch.ToString()))
                {
                    dic[ch.ToString()] += 1;
                }
                else
                {
                    dic.Add(ch.ToString(), 1);
                }
            }


            foreach (var item in dic)
            {
                if (item.Value > 1)
                {
                    result = item.Key;
                    break;
                }
            }

            Console.WriteLine(result);

        }

        public static void RemoveAllDuplicateCharacters(string inputStr)
        {
            HashSet<string> ht = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (char ch in inputStr)
            {
                if (!ht.Contains(ch.ToString()))
                {
                    ht.Add(ch.ToString());
                }
            }

            foreach (var item in ht)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
