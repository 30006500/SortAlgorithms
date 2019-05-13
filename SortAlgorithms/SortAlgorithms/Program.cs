using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortAlgorithms
{
    class Program
    {
        static int[] arr = new int[1000];
        static void Main(string[] args)
        {
            ArrayPop();
            int[] arrins = arr;
            int[] arrbub = arr;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            InsertionSort(arrins);
            stopWatch.Stop();
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            BubbleSort(arrbub);
            stopWatch2.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            TimeSpan ts2 = stopWatch2.Elapsed;
            DisplayBubble(arrbub);
            Console.WriteLine();
            Console.WriteLine("Time To Sort Using Insertion: " + ts);
            Console.WriteLine("Time To Sort Using Bubble: " + ts2);
            Console.ReadKey();
        }

        static void InsertionSort(int[] _arr)
        {
            int temp, j;            
            for (int i = 1; i < _arr.Length; i++)
            {
                j = i;
                temp = _arr[i];
                while (j > 0 && _arr[j - 1] >= temp)
                {
                    _arr[j] = _arr[j - 1];
                    j -= 1;
                }

                _arr[j] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Data Set Using Insertion Sort");
            Console.WriteLine();
            foreach (int x in arr)
            {
                Console.Write(x);
                Console.WriteLine();
            }
        
        }

        static int[] BubbleSort(int[] _arr)
        {
            
            
                /*External loop makes sure we check all of array*/
                for (int i = 0; i < _arr.Length - 1; i++)
                {
                    /*Internal loop goes through the elements and checks each one*/
                    for (int j = 0; j < _arr.Length - 1; j++)
                    {
                        /*If the current element is larger than the next element, swap them*/
                        if (_arr[j] > _arr[j + 1])
                        {
                            int temp = _arr[j + 1];
                            _arr[j + 1] = _arr[j];
                            _arr[j] = temp;
                        }
                    }
                }
                return _arr;
            }

        static void DisplayBubble<T>(T[] _arr)
        {
            foreach (T x in _arr)
            {
                Console.Write(x + " ");
            }
        }

        static void ArrayPop()
        {            
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 99999);
                //Console.WriteLine(arr[i]);
            }            
        }
    }
}
