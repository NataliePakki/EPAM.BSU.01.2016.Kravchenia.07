using System;
using System.Collections;
using System.Collections.Generic;

namespace Task4 {
    public static class Search {
        public static bool BinarySearch<T>(T[] array, T x, IComparer<T> comparer = null) {
            if (comparer != null) return Find(array, x, 0, array.Length - 1, comparer);
            var comparable = x as IComparable<T>;
            if (comparable == null) throw new ArgumentException("Values mustn't comparer.");
            return Find(array, comparable, 0, array.Length - 1);
        }

        private static bool Find<T>(T[] a, T x, int l, int r, IComparer<T> comparer) {
            if (l > r)
                return false;
            if (comparer.Compare(x, a[l]) < 0 || comparer.Compare(x, a[r]) > 0)
                return false;
            int m = (l + r) / 2;
            if (comparer.Compare(x,a[m]) == 0)
                return true;
            if (comparer.Compare(x,a[m]) < 0)
                return Find(a, x, l, m - 1,comparer);
            if (comparer.Compare(x,a[m]) > 0)
                return Find(a, x, m + 1, r,comparer);
            return false;
        }


        private static bool Find<T>(T[] a, IComparable<T> x, int l, int r) {
            if (l > r)
                return false;
            if (x.CompareTo(a[l]) < 0 || x.CompareTo(a[r]) > 0)
                return false;
            int m = (l + r) / 2;
            if (x.CompareTo(a[m]) == 0)
                return true;
            if (x.CompareTo(a[m]) < 0)
                return Find(a, x, l, m - 1);
            if (x.CompareTo(a[m]) > 0)
                return Find(a, x, m + 1, r);
            return false;
        }
    }
}
