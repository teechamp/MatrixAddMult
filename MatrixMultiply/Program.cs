using System;

namespace MatrixMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
         int[] a = new int[6] { 34, 20, 30, 44, 50,60 };

         int[] b = new int[6] { 8, 12, 23, 21, 4, 15 };

            int[] arr = new int[6];

            for (int i = 0; i < a.Length; i++)

            {

                arr[i] = a[i] * b[i];   
                
                 Console.Write(arr[i] + " ");  
                                        

            }

           

           

        }
    }
}