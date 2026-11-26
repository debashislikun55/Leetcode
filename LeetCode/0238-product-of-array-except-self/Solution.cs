public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int len = nums.Length;
        int[] leftproduct = new int[len];
        int[] rightproduct = new int[len];
        int[]  product = new int[len];
        for(int i=0;i<len;i++)
        {
            int left = i>0 ? leftproduct[i-1] :1;
            leftproduct[i]=nums[i]*left;

        }
        
        for(int i=len-1;i>=0;i--)
        {
            int right = i<(len-1)? rightproduct[i+1] :1;
            rightproduct[i]=nums[i]*right;
        }

        for(int i=0;i<len;i++)
        {
            int l =  i>0?leftproduct[i-1]:1;
            int r =  i<(len-1)?rightproduct[i+1]:1;
            product[i]=l*r;
        }

        return product;
    }
}