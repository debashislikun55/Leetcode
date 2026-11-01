public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        //Approach -1 : Brute Force 

        // for(int i=0;i<nums.Length;i++)
        // {
        //     for(int j=i+1;j<nums.Length;j++)
        //     {
                
        //         if(nums[i]+nums[j]==target)
        //         {
        //             return [i,j];
        //         }
        //     }
        // }
        // return new int[]{};

        //Approach -2 : Optimized Approach 

        var seen = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int need = target-nums[i];
            if(seen.ContainsKey(need))
            {
                return [seen[need],i];
            }
            seen[nums[i]]=i;
        }
        return new int[]{};
    }
}