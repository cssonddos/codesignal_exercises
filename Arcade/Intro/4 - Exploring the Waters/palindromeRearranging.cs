bool palindromeRearranging(string inputString) {
    Dictionary<char, int> d = new Dictionary<char, int>();
    
    foreach(char c in inputString){
        if(d.ContainsKey(c)){
            d[c] ++;
        }else{
            d.Add(c, 1);
        }
    }

    int imp = 0;
    foreach( int v in d.Values){
        if(v % 2 != 0){
            imp++;
        }
    }
    if(imp > 1) return false;
    return true;
}