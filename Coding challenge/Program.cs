using System;

namespace Coding_challenge
{
    class Program
    {
        public static void printPermutation(int N, int S, int[] arry)
        {
            if (N - 1 == S)
            {
                Console.Write("[");
                for(int i = 0; i < N; i++)
                {
                    Console.Write(arry[i]);
                    if (i != N - 1) Console.Write(", ");
                }
                Console.Write("]\n");


            }
            else
            {
                int intLeft = N - S;
                int temp;
                for(int i = 0; i < intLeft; i++)
                {
                    temp = arry[S];
                    arry[S] = arry[S + i];
                    arry[S + i] = temp;
                    printPermutation(N, S + 1, arry);
                    temp = arry[S];
                    arry[S] = arry[S + i];
                    arry[S + i] = temp;

                }
            }
        }
        static void Main(string[] args)
        {
            
            int N = Int32.Parse(Console.ReadLine());
            int[] arry = new int[N];
            int added;

            for (int i = 0; i < N; i++)
            {
                added = Int32.Parse(Console.ReadLine());
                arry[i] = added;
            }
            printPermutation(N, 0, arry);
        }
    }
}
