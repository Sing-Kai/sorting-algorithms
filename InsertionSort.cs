
using System;

namespace Sorting
{

    public static class Insertion
    {

        public static int[] Sort(int[] arr)
        {
            for(var i= 0; i < arr.Length-1; i++)
            {
                //get the next elements and loops 
                //loops backwards to find if element needs to be swapd
                for(var j= i+1; j >0; j--){

                    if(arr[j-1] > arr[j]){
                        
                        var temp = arr[j-1];
                        arr[j-1] = arr[j];
                        arr[j] = temp;
                    }

                }
            }

            return arr;
        }
    }
}