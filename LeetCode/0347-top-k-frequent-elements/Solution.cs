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


        //create bucket of n+1 length
        
        var bucket=new List<int>[nums.Length+1];

        foreach(var kvp in freq)
        {
            int count = kvp.Value;
            int num = kvp.Key;
            if(bucket[count]==null)
            {
                bucket[count]= new List<int>();
            }
            bucket[count].Add(num);
        }

        //var result = new int[k];
        int index =0;
        for(int f=bucket.Length-1;f>=1&&index<k;f--)
        {
            if(bucket[f]==null)
            {
                continue;
            }
            foreach (int num in bucket[f])
            {
            result[index++] = num;
            if (index == k) break;
            }
        }

        

        return result;
    }
}
