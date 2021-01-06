int makeArrayConsecutive2(int[] statues) {
    List<int> sortedStatues = statues.ToList();
    sortedStatues.Sort();
    List<int> additional = new List<int>();
    for(int i=0; i<sortedStatues.Count-1; i++){
        
        if((sortedStatues[i] + 1) != sortedStatues[i+1]){
            
            for(int a=sortedStatues[i], inc=1; a<sortedStatues[i+1];a++, inc++){
                int add = sortedStatues[i] + inc;

                if(add!=sortedStatues[i+1]){
                    additional.Add(add);
                }
            }
        }
    }
    return additional.Count;
}