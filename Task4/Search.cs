using System;
using System.Collections.Generic;

namespace Task4 {
    public static class Search {
        public static bool BinarySearch<T>(T[] array, T x, IComparer<T> comparer = null) {
            if (array == null) throw new ArgumentNullException($"{nameof(array)} is null");
            if (comparer == null) comparer = Comparer<T>.Default;
            return Find(array, x, 0, array.Length - 1,comparer);
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
    }
}
