using System;
using System.Collections.Generic;

namespace Task5 {
    public static class Sort{
        public static void BubbleSort<T>(T[] array, IComparer<T> comparer = null){
            if (array == null) throw new ArgumentNullException($"{nameof(array)} is null");
            if (comparer == null) comparer = Comparer<T>.Default;
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++) {
                    if (comparer.Compare(array[j], array[j + 1]) > 0) {
                            Swap(ref array[j], ref array[j + 1]);
                    }
                }
        }
        public static void SelectionSort<T>(T[] array, IComparer<T> comparer = null) {
            if (array == null) throw new ArgumentNullException($"{nameof(array)} is null");
            if (comparer == null) comparer = Comparer<T>.Default;
            for (int i = 0; i < array.Length - 1; i++) {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (comparer.Compare(array[j], array[min]) < 0)
                        min = j;
                if (min != i) {
                    Swap(ref array[i], ref array[min]);
                }
            }
        }

        private static void Swap<T>(ref T x, ref T y){
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

