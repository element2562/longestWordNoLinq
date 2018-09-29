using System;
namespace _3
{
    class MainClass
    {
        public static string LongestWord(string sen)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */
            var strArray = sen.Split(' ');
            string longestWord = "";
            for (int i = 0; i < strArray.Length; i++)
            {
                string eachWord = strArray[i];
                sen = strArray[0];
                if (longestWord.Length < eachWord.Length)
                {
                    longestWord = eachWord;
                }
            }
            sen = longestWord;
            return sen;

        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(LongestWord(Console.ReadLine()));
        }

    }
}