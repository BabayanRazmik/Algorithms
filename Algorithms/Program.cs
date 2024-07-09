using Algorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Binary Search
        int[] arr_BinarySearch = new int[] { 1, 3, 5, 7, 9 };

        BinarySearch binaySearch = new BinarySearch();
        int? index = binaySearch.binary_search(arr_BinarySearch, 10);

        Console.Write("Binary Search : index = ");
        Console.WriteLine(index != null ? index : "null");
        #endregion

        #region Selection Sort
        Console.Write("Selection Sort: ");
        int[] arr_SelectionSort = new int[] { 25, 10, 50, 0, 100 };

        SelectionSort selectionSort = new SelectionSort();
        arr_SelectionSort = selectionSort.selection_sort(arr_SelectionSort);

        foreach (int i in arr_SelectionSort)
        {
            Console.Write($"{i} ");
        }
        #endregion
    }
}