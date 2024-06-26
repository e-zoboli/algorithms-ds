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

    [Fact]
    public void QuickSortTest()
    {
        List<int> expected = [1, 2, 3, 5, 6, 9, 12];
        List<int> lst = [1, 9, 3, 12, 2, 5, 6];
        var res = QuickSortAlgo.QuickSort(lst);
        Assert.Equal(expected, res);

        //test that the original list isn't sorted in place
        Assert.NotSame(lst, res);
        Assert.NotEqual(lst, res);

    }

    [Fact]
    public void GenericQuickSortTestStrings()
    {
        List<string> unsortedList = ["Orange", "Apple", "Banana", "Kiwi", "Peach"];

        List<string> sortedList = ["Apple", "Banana", "Kiwi", "Orange", "Peach"];

        var res = QuickSortAlgo.QuickSort(unsortedList, (x, y) => string.Compare(x, y) < 0);

        Assert.Equal(sortedList, res);
    }

    [Fact]
    public void GenericQuickSortTestInts()
    {
        List<int> unsortedList = [5, 1, 9, 3, 7];

        List<int> sortedList = [1, 3, 5, 7, 9];

        var res = QuickSortAlgo.QuickSort(unsortedList, (x, y) => x < y);

        Assert.Equal(sortedList, res);
    }

    [Fact]
    public void BinarySearchTest_True()
    {
        int[] ints = Enumerable.Range(1, 1_000_000).ToArray();
        int target = 578991;

        var result = BinarySearchAlgo.BinarySearchList(ints, target);
        Assert.True(result);        
    }

    [Fact]
    public void BinarySearchTest_False()
    {
        int[] ints = Enumerable.Range(1, 1_000_000).ToArray();
        int target = 1_000_001;

        var result = BinarySearchAlgo.BinarySearchList(ints, target);
        Assert.False(result);
    }

    [Fact]
    public void TwoCrystalBallsTest_True()
    {
        bool[] breaks = new bool[100];
        for (int i = 70; i < breaks.Length; i++)
        {
            breaks[i] = true;
        }

        int result = TwoCrystalBallsAlgo.TwoCrystalBalls(breaks);

        Assert.Equal(70, result);
    }
    
    [Fact]
    public void TwoCrystalBallsTest_False()
    {
        bool[] breaks = new bool[100];

        int result = TwoCrystalBallsAlgo.TwoCrystalBalls(breaks);

        Assert.Equal(-1, result);
    }
    
    [Fact]
    public void BubbleSortTest()
    {
        int[] unsortedArray = [5, 1, 4, 2, 8];
        int[] sortedArray = [1, 2, 4, 5, 8];

        BubbleSortAlgo.BubbleSort(unsortedArray);

        Assert.Equal(sortedArray, unsortedArray);
    } 
}