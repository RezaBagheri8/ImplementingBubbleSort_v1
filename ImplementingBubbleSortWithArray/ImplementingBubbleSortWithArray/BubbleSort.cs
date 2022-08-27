using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingBubbleSortWithArray
{
    public class BubbleSort
    {
        public int[] array;

        public BubbleSort(int[] inputArray)
        {
            array = new int[inputArray.Length];
            array = inputArray;
        }

        public void Sort()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The array is empty!");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public bool IsEmpty()
        {
            if (array.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
