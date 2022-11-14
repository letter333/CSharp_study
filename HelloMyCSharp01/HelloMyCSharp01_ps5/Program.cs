using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_ps5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("숫자 입력");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("최대 최소 for");
            int max = arr[0];
            int min = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }

                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("최대 : " + max + ", 최소 : " + min);
            Console.WriteLine("최대 최소 인덱스 for");
            for(int i = 0; i < 5; i++)
            {
                if (arr[i] == max)
                {
                    Console.WriteLine("최대값 인덱스 : " + i);
                }
                if (arr[i] == min)
                {
                    Console.WriteLine("최소값 인덱스 : " + i);
                }

            }

            Console.WriteLine("최대 최소 foreach");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("숫자 입력");
                arr[i] = int.Parse(Console.ReadLine());
            }


            max = arr[0];
            min = arr[0];

            foreach (var item in arr)
            {
                if(max < item)
                {
                    max = item;
                }
                if(min > item)
                {
                    min = item;
                }
            }
            Console.WriteLine("최대 : " + max + ", 최소 : " +  min);
            Console.WriteLine("최대 최소 인덱스 foreach");
            foreach (var item in arr.Select((value, index) => (value, index)))
            {
                if(item.value == max)
                {
                    Console.WriteLine("최대 인덱스 : " + item.index);
                }
                if (item.value == min)
                {
                    Console.WriteLine("최소 인덱스 : " + item.index);
                }
            }
        }
    }
}
