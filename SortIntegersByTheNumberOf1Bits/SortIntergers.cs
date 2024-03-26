using System;

namespace Solution {
    public class SortIntergers{
        public int[] SortByBits(int[] arr){
            Array.Sort(arr, (x, y) => {
                int countX = CountSetBits(x);
                int countY = CountSetBits(y);

                if (countX == countY){
                    return x.CompareTo(y); // Sort by original value if bit count is the same
                }
                else{
                    return countX.CompareTo(countY); // Sort by bit count first
                }
            });
            return arr;
        }

         private static int CountSetBits(int n){
        int count = 0;
        while (n > 0){
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
    }
   
}