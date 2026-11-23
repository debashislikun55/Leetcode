public class Solution {
    public bool ValidPalindrome(string s)
    {

        int left = 0;
        int right = s.Length-1;

        while(left<=right)
        {
            if(s[left]==s[right])
            {
                left++;
                right--;
            }

            else
            {
                return checkpalindrome(s,left+1,right) || checkpalindrome(s,left,right-1);
            }
        }
        return true;
        
    }

    public bool checkpalindrome(string s,int left,int right)
    {
        while(left<=right)
        {
            if(s[left]!=s[right])
            {
                return false;
            }

            left++;
            right--;
            
        }
        return true;
       
    }
}