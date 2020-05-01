using System;

namespace QuickSort
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 1, 5, 18, 11, 3, 7, 10, 23 }.SortArr();

      Console.WriteLine();
      Console.WriteLine("Sorted Array: " + String.Join(' ', arr));
    }
  }
}