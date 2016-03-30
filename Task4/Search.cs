using System;

namespace Task4 {
    public static class Search {
        public static bool BinarySearch<T>(T[] array, IComparable<T> x) {
            if (x.CompareTo(array[0]) < 0 || x.CompareTo(array[array.Length - 1]) > 0)
                    return false;
                return Find(array, x, 0, array.Length - 1); 
        }

        private static bool Find<T>(T[] a, IComparable<T> x, int l, int r) {
            if (l > r)
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
