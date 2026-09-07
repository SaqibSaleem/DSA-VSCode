using System.Data;
using System.Net.Mail;
namespace DSA_VSCode._10_Hasshing
{
    public class HashMapClass
    {
        Dictionary<int, string> map = new Dictionary<int, string>();
        public void AddValue()
        {
            map.Add(101, "Ali");
            map.Add(102, "Salman");
            map.Add(103, "umer");
            map.Add(104, "Sara");

        }
        public void ShowMap()
        {
            foreach (KeyValuePair<int, string> item in map)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
        public void ShowKey()
        {
            foreach (KeyValuePair<int, string> item in map)
            {
                Console.WriteLine(item.Key);
            }
        }
        public void ShowValue()
        {
            foreach (KeyValuePair<int, string> item in map)
            {
                Console.WriteLine(item.Value);
            }
        }

        public void ContainKey(int i)
        {
            if (map.ContainsKey(i))
            {
                Console.WriteLine("Key Exist and its value is " + map[i]);
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Key Does not exist");
            }
        }
        public void RemovePair(int i)
        {
            if (map.Remove(i))
            {
                Console.WriteLine("Value Removed");
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }
        }
        // check int Frequency in an array
        public void CheckFrequency()
        {
            int[] numbers = { 2, 3, 2, 5, 3, 2 };
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (frequency.ContainsKey(numbers[i]))
                {
                    frequency[numbers[i]]++;
                }
                else
                {
                    frequency.Add(numbers[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> item in frequency)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
        // Sum of two numbers with HashMap
        public int[] SumNum()
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] numbers = { 2, 11, 15, 7 };
            int Target = 17;
            for (int i = 0; i < numbers.Length; i++)
            {
                int Comp = Target - numbers[i];
                if (map.ContainsKey(Comp))
                {

                    int[] N = { map[Comp], i };
                    return N;
                }
                map.Add(numbers[i], i);
            }
            return new int[] { -1, -1 };

        }

    }
}
