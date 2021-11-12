void QuickSort(int[] array) =>
  QuickSort(array, 0, array.Length - 1);


void QuickSort(int[] array, int leftIndex, int rightIndex)
{
    if (leftIndex >= rightIndex) return; // Nothing left to sort

    int positionOfSortedPivot = Partition(array, leftIndex, rightIndex);

    // Sort left of the value now in its place
    QuickSort(arr, leftIndex, positionOfSortedPivot - 1);

    // Sort right of the value now in its place
    QuickSort(arr, positionOfSortedPivot + 1, rightIndex);
}

int Partition(int[] array, int leftIndex, int rightIndex)
{
    int pivot = array[rightIndex]; // Use farthest right as pivot value

    int low = leftIndex - 1;
    for (int i = leftIndex; i < rightIndex; i++)
    {
        if (arr[i] <= pivot)
        {
            low++; // Increase index of the farthest-right low value
            Swap(arr, i, low);
        }
    }

    low++; // Need to swap pivot to the right of the farthest-right low value
    Swap(arr, rightIndex, low);
    return low;
}

//    QS([5,3,4,1,6,9,2,8,0])
//    low               i                               = farthest right lower value
//       [0,3,4,1,6,9,2,8,5]
//        ^----- pivot position = 0
//    QS([]) // done
//    QS(  [3,4,1,6,9,2,8,5]) // pivot = 5
                low
                      i
//    QS(  [3,4,1,2,9,6,8,5]) // pivot = 5
                  low
                          i
//    QS(  [3,4,1,2,5,6,8,9]) // pivot = 5
      QS(  [3,4,1,2])
           [1,2,3,4]
      QS(  [1])
      QS(      [3,4])
      QS(      [3])
      QS(            [6,8,9])
      QS(            [6,8])
      QS(            [6])

















    // 1. Pick a pivot value
    // 2. Scan from left to right and put smaller values on left of bigger values
    // 3. Move pivot value between left and right sides
    // [5,3,4,1,6,9,2,8,7] => 7 is pivot => [3,1,2] 4 [5,6,7]
                  l
                    i
    // [5,3,4,1,6,2,9,8,7]
                    l
                      i
    // [5,3,4,1,6,2,7,8,9]
        smaller    | | bigger









