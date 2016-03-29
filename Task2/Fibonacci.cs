
using System.Collections.Generic;

namespace Task2 {
    public static class Fibonacci {
        public static IEnumerable<int> GetNumbers(int size) {
            int prev = 1;
            int curr = 1;
            for (int i = 0; i < size; i++) {
                yield return prev;
                int next = prev + curr;
                prev = curr;
                curr = next;
            }
        } 
    }
}
