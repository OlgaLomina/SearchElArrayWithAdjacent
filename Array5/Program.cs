using System;
/*Search an element in an array where difference between adjacent elements is 1.
For example: arr[] = {8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3}

Search for 3 and Output: Found at index 7
 * */
namespace Array5
{
    class Program
    {
        static int searchEl(int[] arr, int size, int key)
        {
            int i = 0;
            while (i < size)
            {
                if (arr[i] == key)
                    return i;

                i += Math.Abs(arr[i] - key);
            }

            return -1;
        }

        static void Main(string[] args)
        {
            //int[] arr = {8 ,7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 };
            int[] arr = { 2, 1, 2, 3, 4, 5, 6 };
            int size = arr.Length;
            int key = 3;
            Console.WriteLine(searchEl(arr, size, key));
            //Console.ReadLine();
        }
    }
}
