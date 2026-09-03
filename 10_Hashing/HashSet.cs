using System.Data;
using System.Diagnostics.Metrics;
using DSA_VSCode._01_Basics;

namespace DSA_VSCode._10_Hasshing
{
    public class HashSetClass
    {
        HashSet<int> HSet = new HashSet<int>();
        public void AddHashSet()
        {

            HSet.Add(10);
            HSet.Add(1250);
            HSet.Add(30);
            HSet.Add(10);

            ShowValue();


        }
        public void CheckValue(int val)
        {
            if (HSet.Contains(val))
            {
                Console.WriteLine(val + " is present in the HashSet");
            }
            else
            {
                Console.WriteLine(val + " is not present in the HashSet");
            }


        }
        public void RemoveValue(int Val)
        {
            HSet.Remove(Val);
            ShowValue();
        }
        public void ShowValue()
        {
            foreach (int i in HSet)
            {
                Console.WriteLine(i);
            }
        }

        // Find Duplicates from Array
        public static void FindDuplicate()
        {
            int[] arr = { 1, 3, 6, 8, 3, 8, 6, 10, 14 };
            HashSet<int> dup = new HashSet<int>();
            HashSet<int> seen = new HashSet<int>();
            foreach (int i in arr)
            {
                if (seen.Contains(i))
                {
                    dup.Add(i);

                }
                seen.Add(i);
            }

            if (dup.Count > 0)
            {
                foreach (int num in dup)
                {
                    Console.Write(num + ", ");
                }
            }
            else
            {
                Console.WriteLine("No Duplicate found");
            }
        }
    }


}