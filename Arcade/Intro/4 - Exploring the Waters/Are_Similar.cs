bool areSimilar(int[] a, int[] b) {

    int diff = 0;
    int sumA = 0, sumB =0;
    
    List<int> la = new List<int>(a);
    List<int> lb = new List<int>(b);
    
    for(int i=0; i< a.Count(); i++)
    {
        sumA += a[i];
        sumB += b[i];
        if(a[i] != b[i]){
            diff++;
        }
        if(!la.Contains(b[i]) || !lb.Contains(a[i])){
            return false;
        }
    }
    if(sumA != sumB){
        return false;
    }
    return diff > 2? false : true;
}
