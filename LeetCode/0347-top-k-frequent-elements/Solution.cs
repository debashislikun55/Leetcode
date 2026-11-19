public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freq = new Dictionary<int,int>();
        var result = new int[k];
        //counting frequency 
        foreach(var item in nums)
        {
            freq[item]= freq.GetValueOrDefault(item)+1;
        }


        for(int i =0;i<k;i++)
        {
             int bestkey = 0 , bestvalue=-1;
             foreach(var kvp in freq)
             {
                   if(kvp.Value>bestvalue)
                   {
                         bestvalue=kvp.Value;
                         bestkey=kvp.Key;
                   }
             }
             result[i]=bestkey;
             freq.Remove(bestkey);
        }

        return result;
    }
}