public class Solution {
    public string MergeAlternately(string word1, string word2)
    {
         int left = 0,right=0;
         
         int n1=word1.Length;
         int n2=word2.Length;
         var sb=new StringBuilder();
         while(left<n1 && right<n2)
         {
              sb.Append(word1[left]);
              sb.Append(word2[right]);
              left++;
              right++;
         }

         while(left<n1)
         {
            sb.Append(word1[left]);
            left++;
         }
         while(right<n2)
         {
            sb.Append(word2[right]);
            right++;
         }

         return sb.ToString();
          
        
    }
}