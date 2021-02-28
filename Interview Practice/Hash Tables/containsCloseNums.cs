bool containsCloseNums(int[] nums, int k) {
    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
    if(nums.Count() == 1 || nums.Count() == 0)
        return false;
        
    for(int i=0; i< nums.Count(); i++){
        if(!dict.ContainsKey(nums[i])){
            dict.Add(nums[i], new List<int>());
            dict[nums[i]].Add(i);
        }else{
            dict[nums[i]].Add(i);
        }
    }
    
    foreach(List<int> l in dict.Values){
        if(l.Count() > 1){
            l.Sort();
            for(int i=0; i< l.Count()-1; i++){
                if((l[i+1] - l[i] <=k))
                    return true;
            }
        }
    }
    return false;
}
