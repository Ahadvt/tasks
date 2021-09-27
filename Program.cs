using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "hello world";
            ChangeAlfabi(word);
        }
        static void ChangeAlfabi(string sentence)
        {
            string[] arry = sentence.Split(" ");

            for (int i = 0; i < arry.Length; i++)
            {
                char[] word1 = arry[i].ToCharArray();
                string word2 = string.Empty;

                for (int z = word1.Length - 1; z >= 0; z--)
                {
                    word2 += word1[z];
                }
                Console.Write(word2);

            }



        }

    }
}
