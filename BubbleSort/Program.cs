using BubbleSortLib;

namespace SortingProject;

internal class Program
{
    static void Main(string[] args)
    {
        //given array of integers
        int[] arr = { 1, 20, 3, 4, 5, 60, 7, 8, 9, };
        
        //sort the given array with bubbleSort approach
        arr = RunBubbleSort(arr);
        
        //print array
        foreach (int i in arr) 
        {
            Console.WriteLine(i);
        }
    }

    /// <summary>
    /// Creates create current instance of the class and invokes corresponding sorting method.
    /// </summary>
    /// <param name="array">Array of integer type elements.</param>
    /// <returns>Returns array of integers representing the sorted given array.</returns>
    static int[] RunBubbleSort(int[] array)
    {
        //create instance of the class
        BubbleSortLogic bubbleSortLogic = new BubbleSortLogic();
        
        //invoke sorting method and return the sorted array
        return bubbleSortLogic.Sort(array);
    }
    
}