using Algorithms;
namespace AlgorithmsTest;

public class AlgorithmsTests
{
    [Fact]
    public void MergeSortTest()
    {
        int[] arr = [1, 9, 3, 12, 2, 5, 6];
        int[] expected = [1, 2, 3, 5, 6, 9, 12];
        MergeSortAlgo.MergeSort(arr, 0, arr.Length - 1);
        Assert.Equal(expected, arr);
    }
}