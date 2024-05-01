namespace Algorithms;

public class MergeSortAlgo
{
public static void Merge(int[] arr, int startSubA, int endSubA, int endSubB)
{
    int lenghtSubA = endSubA - startSubA + 1;
    int lenghtSubB = endSubB - endSubA;

    int[] SubA = arr[startSubA..^(endSubB - endSubA)];
    int[] SubB = arr[(endSubA + 1).. ^0];

    int l, m, k;

    l = 0;
    m = 0;
    k = startSubA;

    while(l < lenghtSubA && m < lenghtSubB)
    {
        if(SubA[l] <= SubB[m])
        {
            arr[k] = SubA[l];
            l++;
        }
        else
        {
            arr[k] = SubB[m];
            m++;
        }
        k++;
    }

    while(l < lenghtSubA)
    {
        arr[k] = SubA[l];
        l++;
        k++;
    }
    while(m < lenghtSubB)
    {
        arr[k] = SubB[m];
        m++;
        k++;
    }


}    
public static void MergeSort(int[] arr, int l, int r )
{
    if(l < r)
    {
        int m = l + (r - l) / 2;
        MergeSort(arr, l, m);
        MergeSort(arr, m+ 1, r);
        
        Merge(arr, l, m, r);
    }
}
}