public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        var count = new Dictionary<int,int>();

        foreach(int number in nums)
        {
            count[number]=count.GetValueOrDefault(number)+1;
        }

        foreach(var kvp in count)
        {
            if(kvp.Value>1)
            {
                return true;
            }
        }
        
        return false;
    }
}