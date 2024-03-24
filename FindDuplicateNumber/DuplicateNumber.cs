using System;
using System.Collections.Generic;

namespace DuplicateNumber 
{
    public class FindDuplicate
    {
     public int  FindDuplicateNumber(int[] nums) 
    {
        int x = nums[0];
        int y = nums[0];
        
        while(true)
        {
            //Move one step forward
            x = nums[x];
            
                //Move two steps forward
                if(nums.Length > y)
                {
                    y = nums[nums[y]];
                }
                else
                {
                    return -1;
                }
                if(x == y)
                {
                    break;
                }
        }
            
            //Reset x to the beginning of the array
            x = nums[0];
            //Move x and y until they meet again
            while(x != y)
            {
                x = nums[x];
                y = nums[y];
            }
            // The element pointed to is now duplicate
            return x;
    }
    }
}