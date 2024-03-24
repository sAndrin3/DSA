using System;
using DuplicateNumber;

namespace FindDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 7, 4, 2, 2 };

            FindDuplicate finder = new FindDuplicate();
            int  duplicateNumbers = finder.FindDuplicateNumber(numbers);


            if (duplicateNumbers == 0)
            {
                Console.WriteLine("No duplicates found: ");
            }
            else
            {
            
                Console.WriteLine("Duplicate found: " + duplicateNumbers);
            }
        }
    }
}
