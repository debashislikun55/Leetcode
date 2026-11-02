public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {

        int minLength=int.MaxValue;

        foreach(var word in strs)
        {
            if(word.Length<minLength)
            {
                minLength = word.Length;
            }
        }
    
        for(int i=0;i<minLength;i++)
        {
            char ch = strs[0][i];
            foreach(var word in strs)
            {
                if(word[i]!=ch)
                {
                    return word.Substring(0,i);
                }
            }
           
        }
        return strs[0].Substring(0,minLength);
        
    }
}