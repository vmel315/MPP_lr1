using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-100, 100);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " | ");
            }

            QuickSort<int> q = new QuickSort<int>();
            Console.WriteLine("\n");
            q.Sort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " | ");
            }
            Console.Read();
        }
    }
    public class QuickSort<T> where T : IComparable<T>
    {
        public T Piviot { get; set; }
        public void Sort(T[] elements, int left, int right)
        {
            int i = left, j = right;
            Piviot = elements[(left + right) / 2];
            while (i <= j)
            {
                while (elements[i].CompareTo(Piviot) < 0)
                    i++;
                while (elements[j].CompareTo(Piviot) > 0)
                    j--;
                if (i <= j)
                {
                    Swap(ref elements[i], ref elements[j]);
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Sort(elements, left, j);
            }
            if (i < right)
            {
                Sort(elements, i, right);
            }
        }

        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
