// Challenge: https://leetcode.com/problems/sort-array-by-parity/

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        //create pointer to end of array
        var rightIndex = nums.Length - 1;
        
        //create pointer to beginning. increment while it is less than the end incrementer
        for(var leftIndex = 0; leftIndex < rightIndex; leftIndex++){
            
            if(IsOdd(nums[leftIndex])){
                
                //while the end decrementer is larger than the beginning iterator
                for(; rightIndex > leftIndex; rightIndex--){
                    
                    //if it's even
                    if(!IsOdd(nums[rightIndex])){
                        var swap = nums[leftIndex];
                        nums[leftIndex] = nums[rightIndex];
                        nums[rightIndex] = swap;
                        break;
                    }                    
                }                                
            }
        }
        
        return nums;
    }
    
    private static bool IsOdd(int num) => num % 2 == 1;
}