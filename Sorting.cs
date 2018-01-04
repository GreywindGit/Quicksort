using System.Collections.Generic;

namespace Quicksort
{
    class Sorting
    {
        public static void Quicksort(List<int> arrayToSort, int lowest, int highest)
        {
            if (lowest < highest)
            {
                int pivot = Partition(arrayToSort, lowest, highest);
                Quicksort(arrayToSort, lowest, pivot - 1);
                Quicksort(arrayToSort, pivot + 1, highest);
            }
        }

        public static int Partition(List<int> arrayToSort, int lowest, int highest)
        {
            int pivot = arrayToSort[highest];
            int i = lowest - 1;
            for (int j = lowest; j < highest; j++)
            {
                if (arrayToSort[j] < pivot)
                {
                    i++;
                    int temp = arrayToSort[j];
                    arrayToSort[j] = arrayToSort[i];
                    arrayToSort[i] = temp;
                }   
            }
            if (arrayToSort[highest] < arrayToSort[i + 1])
            {
                int temp = arrayToSort[highest];
                arrayToSort[highest] = arrayToSort[i + 1];
                arrayToSort[i + 1] = temp;
            }
            return i + 1;
        }
    }
}
