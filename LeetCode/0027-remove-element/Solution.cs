public class Solution 
{
    public int RemoveElement(int[] nums, int val)
    {
         int k=0;
        int len = nums.Length;
        if(len==0)
        {
            return 0;
        }

         for (int i =0;i<len;i++)
         {
            if(nums[i]!=val)
            {
                nums[k]=nums[i];
                k++;
            }

         }

         return k;
        
    }
}
