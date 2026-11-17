public class Solution {
    public void SortColors(int[] nums)
    {
         int n = nums.Length;
         Sort(nums,0,n-1);
         
    }

    public void Sort(int[] nums,int low,int high)
    {
        if(low>=high)
        {
            return ;
        }
        int p = pivot( nums, low, high);
        Sort(nums,low,p-1);
        Sort(nums,p+1,high);
    }

    public int pivot(int[] nums, int low, int high)
{
    int pivot = nums[low];
    int i = low;
    int j = high;

    while(i < j)
    {
        while(i <= high && nums[i] <= pivot)
        {
            i++;
        }

        while(j >= low && nums[j] > pivot)
        {
            j--;
        }

        if(i < j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }

    int temporary = nums[j];
    nums[j] = nums[low];
    nums[low] = temporary;

    return j;
}
}