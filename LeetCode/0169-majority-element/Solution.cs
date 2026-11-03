public class Solution {
    public int MajorityElement(int[] nums) 
    {
        int current_major=0,count=0;
        for(int i =0;i<nums.Length;i++)
        {
            if(count==0)
            {
                current_major=nums[i];
                count=1;

            }
            else if(nums[i]==current_major)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return current_major;
        
    }
}