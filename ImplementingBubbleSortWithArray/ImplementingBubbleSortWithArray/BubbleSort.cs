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
                    int k = 0;
                    for (int j = k + 1; j < array.Length; j++)
                    {
                        if (array[k] > array[j])
                        {
                            int temp = array[k];
                            array[k] = array[j];
                            array[j] = temp;
                        }
                        k++;
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
