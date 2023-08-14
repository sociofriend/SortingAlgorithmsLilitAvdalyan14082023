using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLib;

public class BubbleSortLogic
{
    /// <summary>
    /// Sorts given array in bubbleSort approach.
    /// </summary>
    /// <param name="array">Given array of integers.</param>
    /// <returns>Returns sorted array.</returns>
    public int[] Sort(int[] array)
    {
        //maximum index  for comparison
        int indexMax = array.Length;
        
        //current element of the array
        int current;

        //loop starting from index 0 to the first element of the second part of the array.
        while (indexMax > (indexMax / 2 + 1) )
        { 
            for (int i = 0; i < indexMax; i++)
            {
                // if next element is greater than the current item, swap
                if (i + 1 < indexMax &&
                    array[i] > array[i + 1])
                {
                    current = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = current;
                }
            }
            //decrement max index, as the last element of the is already the biggest
            indexMax--;
        }
        return array;
    }

}
