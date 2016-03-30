using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5 {
    public static class Sort{
        public static void BubbleSort<T>(T[] array, IComparer<T> comparer = null){
            if (array == null) throw new ArgumentNullException($"{nameof(array)} is null");
            if (comparer == null) {
                    BubbleSort(array);
            } else {
                for (int i = 0; i < array.Length - 1; i++)
                    for (int j = 0; j < array.Length - i - 1; j++) {
                        if (comparer.Compare(array[j], array[j + 1]) < 0) {
                            Swap(ref array[j], ref array[j + 1]);
                        }
                    }
            }
        }

        public static void SelectionSort<T>(T[] array, IComparer<T> comparer = null) {
            if (array == null) throw new ArgumentNullException($"{nameof(array)} is null");
            if (comparer == null) {
                    SelectionSort(array);
            } else {
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
        }

        private static void BubbleSort<T>(T[] array) {
            if (array.All(x => x is IComparable<T>)) {
                for (int i = 0; i < array.Length - 1; i++)
                    for (int j = 0; j < array.Length - i - 1; j++) {
                        if (((IComparable<T>) array[j]).CompareTo(array[j + 1]) > 0) {
                            Swap(ref array[j], ref array[j + 1]);
                        }
                    }
            }
            else throw new ArgumentException("Values mustn't comparer");
        }

        private static void SelectionSort<T>(T[] array) {
            if (array.All(x => x is IComparable<T>)) {
                for (int i = 0; i < array.Length - 1; i++) {
                    int min = i;
                    for (int j = i + 1; j < array.Length; j++)
                        if (((IComparable<T>) array[j]).CompareTo(array[min]) < 0)
                            min = j;
                    if (min != i) {
                        Swap(ref array[i], ref array[min]);
                    }
                }
            }
            else throw new ArgumentException("Values mustn't comparer");
        }

        private static void Swap<T>(ref T x, ref T y){
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

