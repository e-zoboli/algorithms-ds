using DataStructures;

namespace DataStructuresTest;

public class DoubleLinkedListTest
{
    [Fact]
    public void AddLastCountAndNextTest()
    {
        int[] testData = CreateTestDataArray();
        var sut = new DoubleLinkedList<int>();
        foreach(var i in testData)
        {
            sut.AddLast(i);
            Assert.Equal(sut.Last.Value, i);
        }
        Assert.Equal(sut.Count, testData.Length);
        Assert.True(LinkedListMatchesArray(sut, testData));
    }

    [Fact]
    public void AddFirstCountAndPreviousTest()
    {
        int[] testData = CreateTestDataArray();
        var sut = new DoubleLinkedList<int>();

        foreach(var i in testData)
        {
            sut.AddFirst(i);
            Assert.Equal(sut.First.Value, i);
        }
        Assert.Equal(sut.Count, testData.Length);

    }

    private static int[] CreateTestDataArray()
    {
        return Enumerable.Range(0, 10).ToArray();
    }

    public static bool LinkedListMatchesArray(DoubleLinkedList<int> list, int[] array)
    {
        DoubleLinkedList<int>.Node currentNode = list.First!;

        for (int i = 0; i < list.Count; i++)
        {
            if (currentNode == null || currentNode.Value != array[i])
            {
                return false;
            }
            currentNode = currentNode.Next;
        }

        if (currentNode != null)
        {
            return false;
        }

        return true;
    }
}