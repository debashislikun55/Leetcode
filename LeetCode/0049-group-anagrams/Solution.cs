public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var anagramcheck = new Dictionary<string,List<string>>();

        foreach(var word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if(!anagramcheck.TryGetValue(key,out var list ))
            {
                  list = new List<string>();
                  anagramcheck[key]=list;

            }

            list.Add(word);

        }

        return new List<IList<string>>(anagramcheck.Values);
    }
}