using System.Drawing;

namespace Algorithms;

public static class QuickSortAlgo
{
   public static List<int> QuickSort(List<int> lst)
   {
        List<int> res = lst[..^0];
        int low = 0;
        int high = res.Count - 1;    

        if(high - low < 1)
            return res;
        var mid = low + (high - low) / 2;
        var pivot = res[mid];

        List<int> less = []; 
        List<int> greater = []; 

        foreach(int num in res)
        {
            if(num < pivot)
            {
                less.Add(num);
            }
            if( num > pivot)
            {
                greater.Add(num);
            }

        }
        return [.. QuickSort(less), pivot, .. QuickSort(greater)];

   }
   public static List<T> QuickSort<T>(List<T> lst, Func<T, T, bool> predicate)
   {
        List<T> res = lst[..^0];
        int low = 0;
        int high = res.Count - 1;    

        if(high - low < 1)
            return res;
        var mid = low + (high - low) / 2;
        var pivot = res[mid];

        List<T> subA = []; 
        List<T> subB = []; 
        foreach(T item in res)
        {
            if(predicate(item, pivot))
            {
                subA.Add(item);
            }
            if(predicate(pivot, item))
            {
                subB.Add(item);
            }
        }
        return [.. QuickSort(subA, predicate), pivot, .. QuickSort(subB, predicate)];
   }
}