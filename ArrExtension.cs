namespace QuickSort
{
  public static class ArrExtension
  {
    public static int[] SortArr(this int[] arr)
    {
      return arr.QuickSort(0, arr.Length - 1);
    }

    private static int[] QuickSort(this int[] arr, int start, int end)
    {
      int pivot = (start + end) / 2;
      int pivotVal = arr[pivot];
      int leftPos = start;
      int rightPos = end - 1;

      // move pivotVal to the right
      arr.Swap(pivot, end);

      // if arr only has 2 values, compare and swap if necessary
      if (end - start == 1)
      {
        if (arr[start] > arr[end]) arr.Swap(start, end);
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
          if (arr[leftPos] > pivotVal) arr.Swap(leftPos, end);
          break;
        }

        arr.Swap(leftPos, rightPos);
      }

      if (leftPos - start > 1) arr.QuickSort(start, leftPos);
      if (rightPos < end - 1) arr.QuickSort(leftPos, end);

      return arr;
    }

    private static int[] Swap(this int[] arr, int i, int j)
    {
      int t = arr[i];
      arr[i] = arr[j];
      arr[j] = t;
      return arr;
    }
  }
}