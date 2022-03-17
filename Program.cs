using java.lang;
using System;
using System.Text;

namespace StrinStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String,StringBuilder,StringBuffer
            //Console.WriteLine(NumOfOnes(7));
            //string word = "hello";
            //string word1 = word;
            //word1 = "bye";
            //string n = "hello";
            //Console.WriteLine(word == n);
            //foreach (var letter in word)
            //{
            //    Console.WriteLine(letter);
            //}
            //Console.WriteLine(ReverseSB("hello"));
            //StringBuilder sb1 = new StringBuilder("test");
            //StringBuilder sb2 = new StringBuilder("test");
            //Console.WriteLine(sb2==sb1);
            //string s1 = "test";
            //string s2 = "test";
            //Console.WriteLine(s2==s1);
            //StringBuffer sb = new StringBuffer();
            #endregion

            string word = "   Hello Bp201  ";

            //int r=word.IndexOf("l",3,1);
            //int r=word.LastIndexOf("l");
            //string r=word.Remove(5);
            //string r = word.Replace("ol", "o");
            //bool r = word.Contains("Bp");
            //string r = word.ToUpper();
            //Console.WriteLine(r);
            //Console.WriteLine(word.Trim().Length);

        }

        //static StringBuilder ReverseSB(string str)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        result.Append(str[i]);
        //    }
        //    return result;
        //}

        //static string Reverse(string str)
        //{
        //    string result = String.Empty;
        //    for (int i= str.Length-1;  i>=0; i--)
        //    {
        //        result += str[i];
        //    }
        //    return result;
        //}

        #region Homework
        /// <summary>
        /// Get bit count
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>integer</returns>
        //static int NumOfOnes(int n)
        //{
        //    if (n == 1)
        //        return n;
        //    return (n & 1) + NumOfOnes(n >> 1);
        //}
        #endregion


    }
}
