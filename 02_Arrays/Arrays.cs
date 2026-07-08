using System.Data;
using System.Diagnostics.Metrics;

namespace DSA_VSCode._02_Arrays

{
    public class Arrays
    {
        // Print An Array
        public static void PrintArray()
        {
            int[] Input = [10, 20, 30, 40, 50];
            for (int i = 0; i < Input.Length; i++)
            {

                Console.WriteLine(Input[i]);
            }
            //Console.WriteLine(Input.Length);
        }
        // Sum of Array
        public static void ArrSum()
        {
            int[] Arr = [5, 10, 15, 20];
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            Console.WriteLine(sum);
        }
        // Find Largest Element
        public static void FindMax()
        {
            int[] GivenArr = [5, 9, 2, 17, 8];

            int max = 0;
            for (int i = 0; i < GivenArr.Length; i++)
            {
                Console.WriteLine(GivenArr[i]);
                if (max < GivenArr[i])
                {
                    max = GivenArr[i];
                }
            }
            Console.WriteLine("Max Number in Array is : " + max);
        }
        // Find Minimum Number
        public static void FindMin()
        {
            int[] GivenArray = [12, 5, 18, 3, 14, 2];
            int min = GivenArray[0];
            for (int i = 0; i < GivenArray.Length; i++)
            {
                Console.WriteLine(GivenArray[i]);

                if (min > GivenArray[i])
                {
                    min = GivenArray[i];
                }
            }
            Console.WriteLine("Min number is : " + min);
        }
        // Average of Array
        public static void AvgArray()
        {
            int[] AvgArr = [10, 20, 30, 40, 25, 2];
            int sum = 0;
            int Avg = 0;
            for (int i = 0; i < AvgArr.Length; i++)
            {
                sum += AvgArr[i];
            }
            Avg = sum / AvgArr.Length;
            Console.WriteLine(Avg);
        }
        // Search from array
        public static void SearchNum(int num)
        {
            int[] Arr = [4, 7, 2, 9, 1];
            int index = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == num)
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
        // Count Occurrences
        public static void CountOccurrence()
        {
            int[] Arr = [1, 2, 3, 2, 4, 2, 2];
            int Counter = 0;
            int[] NewArr = [];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 2)
                {
                    Counter++;
                }
            }
            Console.WriteLine("Count Occurrences = " + Counter);
        }
    }

}