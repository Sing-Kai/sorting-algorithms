using System;

namespace Sorting
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] arr)
        {
            int temp, smallest;

            /*
            1. find the smallest value in remaining array in inner loop
            2. store the index of smallest value
            3. swap with current position
            */

            for(var i =0; i <arr.Length -1; i++)
            {
                //current index
                smallest = i;
                
                for(var j= i+1; j< arr.Length; j++)
                {
                    if(arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;

            }
            
            return arr;
        }

    }
}