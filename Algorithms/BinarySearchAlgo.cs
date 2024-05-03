namespace Algorithms;

public class BinarySearchAlgo
{
   public static bool BinarySearchList(int[] arr, int number)
   {
        var lo = 0;
        var hi = arr.Length - 1;

        do
        {
            var mid = lo + (hi - lo)/2;
            if( arr[mid] == number)
            {
                return true;
            }
            else if( arr[mid] > number)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            } 
        
        }while(lo < hi);
        
        return false;
   }
}