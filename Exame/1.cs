
using System;
using System.Collections.Generic;


namespace ConsoleApp1._2
{
    class GFG
    {
        static int[] deno = { 1, 5, 10, 20, 50, };
        static int n = deno.Length;

        static void findMin(int V)
        {

            List<int> ans = new List<int>();

            for (int i = n - 1; i >= 0; i--)
            {

                while (V >= deno[i])
                {
                    V -= deno[i];
                    ans.Add(deno[i]);
                }
            }

            for (int i = 0; i < ans.Count; i++)
            {
                Console.Write(" " + ans[i]);
            }
        }
        public static void Main(String[] args)
        {

            int n = 80;
            Console.Write("Following is minimal number " +
                          "of change for " + n + ": ");

            findMin(n);
        }
    }
}
