int[] sortByHeight(int[] a) {
    List<int> nl = a.ToList();
    nl.RemoveAll(x => x== -1);
    nl.Sort();
    int ind = 0;
    for(int i=0; i< a.Count(); i++){
        if(a[i] != -1){
            a[i] = nl[ind++];
        }
    }
    
    return a;
}