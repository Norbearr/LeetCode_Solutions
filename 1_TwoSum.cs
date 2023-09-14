public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] result = new int[2];
        int k = nums.Length;
        for(int i = 0; i < k; i++)
        {
            int key  = nums[i];
            //int f = 0;
            for(int j = i+1; j < k; j++)
            {
                if((key + nums[j]) == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
                
            }
            
        }
        return result;
        
    }

}
