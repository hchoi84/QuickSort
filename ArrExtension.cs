namespace QuickSort
{
  public static class ArrExtension
  {
    public static int[] SortArr(this int[] arr)
    {
      return QuickSort(arr, 0, arr.Length - 1);
    }

    public static int[] QuickSort(int[] arr, int start, int end)
    {
      int pivot = (start + end) / 2;
      int pivotVal = arr[pivot];
      int leftPos = start;
      int rightPos = end - 1;

      // move pivotVal to the right
      arr[pivot] = arr[end];
      arr[end] = pivotVal;

      // if arr only has 2 values, compare and swap if necessary
      if (end - start == 1)
      {
        if (arr[start] > arr[end]) Swap(arr, start, end);
        return arr;
      }

      // values less than pivotVal to the left and greater to the right
      while (true)
      {
        while (leftPos < rightPos)
        {
          if (arr[leftPos] < pivotVal) leftPos++;
          else break;
        }

        while (rightPos > leftPos)
        {
          if (arr[rightPos] > pivotVal) rightPos--;
          else break;
        }

        if (rightPos == leftPos)
        {
          if (arr[leftPos] > pivotVal) Swap(arr, leftPos, end);
          break;
        }

        Swap(arr, leftPos, rightPos);
      }

      if (leftPos - start > 1) QuickSort(arr, start, leftPos);
      if (rightPos < end - 1) QuickSort(arr, leftPos, end);

      return arr;
    }

    public static int[] Swap(int[] arr, int i, int j)
    {
      int t = arr[i];
      arr[i] = arr[j];
      arr[j] = t;
      return arr;
    }
  }
}