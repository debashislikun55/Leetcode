public class Solution {
    public int[] SortArray(int[] nums) 
    {

        int n = nums.Length;
        int[] temp = new int[n];

        Divide(nums,temp,0,n-1);
        return nums;
    }

    public void Divide(int[] nums ,int[] temp, int low , int high )
    {
        if(low>=high)
        {
            return ;
        }
        int mid = (low+high)/2;
        Divide(nums,temp,low,mid);
        Divide(nums,temp,mid+1,high);
        Merge(nums,temp,low,mid,high);
    }

    public void Merge(int[] arr,int[] temp,int low,int mid,int high)
    {
        
        int k =low;
        int i = low,j=mid+1;
        while(i<=mid && j<=high)
        {
            if(arr[i]<=arr[j])
            {
                temp[k]=arr[i];
                i++;
                k++;
            }
            else 
            {
                temp[k]=arr[j];
                j++;
                k++;
            }
        }

        while(i<=mid)
        {
            temp[k]=arr[i];
            k++;
            i++;
        }
        while(j<=high)
        {
            temp[k]=arr[j];
            j++;
            k++;
        }
        for(int index=low;index<=high;index++)
        {
            arr[index]=temp[index];
        }

    } 
}