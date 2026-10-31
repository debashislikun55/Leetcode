public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        var dict1= new Dictionary<char,int>();


        if(s.Length!=t.Length)
        {
            return false;
        }

        foreach(char ch in s)
        {
            dict1[ch]=dict1.GetValueOrDefault(ch)+1;
        }

        foreach(char ch in t)
        {
            if(!dict1.TryGetValue(ch,out var n) || n==0 )
            {
                return false;
            }
            dict1[ch]--;
        }
        return true;
        
    }
}