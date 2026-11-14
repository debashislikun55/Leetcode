public class MyHashSet {

    public const int B = 769;
        public readonly List<int>[] Bucket = new List<int>[B];
        

        public int Hash(int key)=>key%B;
    public MyHashSet() {

    }
    
    public void Add(int key) 
    {
         int i = Hash(key);
         if(Bucket[i]==null)
         {
            Bucket[i]= new List<int>();
         }
         if(!Bucket[i].Contains(key))
         {
             Bucket[i].Add(key);
         }
        
    }
    
    public void Remove(int key) 
    {
        int i = Hash(key);
        if(Bucket[i]!=null)
        {
            Bucket[i].Remove(key);
        }
        
    }
    
    public bool Contains(int key) 
    {

        int i = Hash(key);
        if(Bucket[i]!=null)
        {
            return Bucket[i].Contains(key);
        }
        return false;
        
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */