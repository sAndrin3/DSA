using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace DuplicateNumber 
{
    public class FindDuplicate
    {
        public List<int> FindDuplicateNumbers(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentException(nameof(nums), "Input array cannot be null.");
            }
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int num in nums)
            {
                if (!seen.Add(num))
                {
                    duplicates.Add(num);
                }
            }

            return duplicates;
        }
    }
}