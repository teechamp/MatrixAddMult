using System;

namespace MatrixAdd
{
    class Program
    {
        static void Main(string[] args)
        {
           
         int[] a = new int[6] { 34, 20, 30, 44, 50, 60};

         int[] b = new int[6] { 8, 12, 23, 21, 4, 15 };

            int[] arr = new int[6];

            for (int i = 0, j = 0; i < b.Length; i++, j++)

            {

                arr[i] = a[i] + b[j];                             

            }

            for (int i = 0; i < arr.Length; i++)

            {

                Console.Write(arr[i] + " ");

            }

            Console.Read();

        }
    }
}