using Solution;

namespace SortByBits{
    class program {
        static void Main(){
            SortIntergers solution = new SortIntergers();
            int[] arr = {5, 2, 3, 9, 14};
            int[] sortedArr = solution.SortByBits(arr);

            Console.WriteLine("Sorted Array:");
            foreach (var num in sortedArr){
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
