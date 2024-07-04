using Algorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 3, 5, 7, 9 };

        BinarySearch binaySearch = new BinarySearch();
        int? index = binaySearch.binary_search(arr, 9);

        Console.Write("Binary Search : index = ");
        Console.WriteLine(index != null ? index : "null");
    }
}