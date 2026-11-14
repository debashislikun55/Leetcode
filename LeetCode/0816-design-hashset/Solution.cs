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




method 2 





    public class MyHashSet {

    private  List<int>[] Bucket = new List<int>[5];
    private const double maxloadfactor=1.0;
    private int count = 0;
    public int Hash(int key,int size)=> key%size;
    

    public MyHashSet() {
        
    }
    
    public void Add(int key) {
        
        int i = Hash(key,Bucket.Length);
       
        if(Bucket[i]==null)
        {
            Bucket[i]= new List<int>();
        }
        if(Bucket[i].Contains(key))
        {
            return ;
        }

        Bucket[i].Add(key);
        count++;
        if((double)count/Bucket.Length>maxloadfactor)
        {
            Resize();
        }
    }
    
    public void Remove(int key) {
        
        int i = Hash(key,Bucket.Length);
        if(Bucket[i]!=null)
        {
            if(Bucket[i].Remove(key))
            {
                 count--;
            }
            
        }
    }
    
    public bool Contains(int key)
    {
        int i = Hash(key,Bucket.Length);
        if(Bucket[i]!=null)
        {
            return Bucket[i].Contains(key);
        }
        return false;
        
    }

    public void Resize()
    {
        var newBucket = new List<int>[2*Bucket.Length];
        foreach(var chain  in Bucket)
        {
            if(chain==null)
            {
                continue;
            }
            foreach(var key in chain)
            {
                 int i = Hash(key,newBucket.Length);
                if(newBucket[i]==null)
                {
                    newBucket[i]= new List<int>();
                }
                newBucket[i].Add(key);
            }
           
        }
        Bucket=newBucket;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
