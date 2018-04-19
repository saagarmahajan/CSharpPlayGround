using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Solutions
{
    class StringsClass
    {
        static void Main(string[] args)
        {
            var result = RemoveDuplicateCharacters("saagar");
            var result2 = CheckAnagrams("lsten", "silent");
            PrintFizzBuzz();
            PrintDuplicateCharacter();
            var result3 = CheckIfStringhasDuplicates("sagar");
            var result4 = FirstNonRepeatedChar("Sagar");
            var result5 = ReverseString("sagar mahajan");
            var result6 = ReverseeachWordInString("I love my country");

            // Display only letters.
            string txtLetters = "29 sbfshf sn dfsf 2984 2";
            Regex.Replace(txtLetters, "[^a-zA-Z]", "");

            //Display only numbers.
            Regex.Replace(txtLetters, "[^0-9]", "");
            var result7 = CheckIfpalindrome("sagas");

        }

        #region string

        public static string RemoveDuplicateCharacters(string inputString)
        {
            string result = string.Empty;
            string table = "";

            if (string.IsNullOrEmpty(inputString) || inputString.Length < 2)
                return inputString;
            // Loop over each character.
            foreach (char value in inputString)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }
        public static bool CheckAnagrams(string word1, string word2)
        {
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            if (word1.Length != word2.Length)
                return false;
            else
            {
                foreach (char c in word1)
                {
                    if (!word2.Contains(c))
                        return false;
                }
            }
            return true;

            //return (new string(word1.OrderBy(x => x).ToArray())== new string(word2.OrderBy(y => y).ToArray()));

            //char[] char1 = word1.ToCharArray();
            //char[] char2 = word2.ToCharArray();
            //Array.Sort(char1);
            //Array.Sort(char2);
            //string newWord1 = new string(char1);
            //string newWord2 = new string(char2);
            //if (newWord1 == newWord2)
            //{
            //    return true;
            //}
            //else return false;
        }
        public static void PrintFizzBuzz()
        {
            Enumerable.Range(1, 100).ToList()
                .ForEach(x =>
                {
                    Console.WriteLine("{0}{1}{2}",

                        x % 3 == 0 ? "Fizz" : "",
                        x % 5 == 0 ? "Buzz" : "",
                        x % 3 != 0 && x % 5 != 0 ? x.ToString() : "");
                });


        }
        public static void PrintDuplicateCharacter()
        {
            string inputSting = "saglkajfponflkfncohdacdsvpeoar";
            var result = inputSting.GroupBy(c => c).Where(c => c.Count() > 1).Select(c => new { charname = c.Key, charvalue = c.Count() });
            foreach (var val in result)
            {
                Console.WriteLine(val.charname.ToString() + " " + val.charvalue.ToString());
            }

        }
        public static bool CheckIfStringhasDuplicates(string inputString)
        {

            return (inputString.Distinct().Count() == inputString.Length);

            //return (inputString.GroupBy(x => x).Any(x => x.Count() > 1));

            //var set = new HashSet<char>();
            //return inputString.Any(x => !set.Add(x));
        }
        public static string FirstNonRepeatedChar(string inputString)
        {
            string result = "";
            foreach (char c in inputString)
                if (inputString.LastIndexOf(c) == inputString.IndexOf(c))
                    return c.ToString();
            return result;
        }
        public static string ReverseString(string inputString)
        {
            return (new string(inputString.Reverse().ToArray()));
        }
        public static string ReverseeachWordInString(string inputString)
        {
            string newstring = string.Join(" ", inputString.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            string text = string.Join(" ", inputString.Split(' ').Reverse());
            return newstring;
        }
        public static bool CheckIfpalindrome(string word)
        {
          // return word.SequenceEqual(word.Reverse());

            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                    return false;
            }
            return true;
        }


        #endregion

    }


}
