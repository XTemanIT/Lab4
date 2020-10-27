using System;

namespace Lab1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, err = 0;
            N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < N; i++)
            {
                if (arr[i] - arr[i-1] > 1)
                {
                    err = arr[i];
                    continue;
                }
            }
            if (err == 0)
            {
                Console.WriteLine(err);
            } else Console.WriteLine(err);
        }
    }
}
