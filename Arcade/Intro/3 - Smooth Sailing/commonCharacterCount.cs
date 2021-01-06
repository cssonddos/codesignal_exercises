int commonCharacterCount(string s1, string s2) {
    
    int count = 0;
    
    var lista = s1.ToList();
    lista.Sort();
    s1 = String.Concat(lista);
    
    lista = s2.ToList();
    lista.Sort();
    s2= String.Concat(lista);
    
    for(int i = 0; i < s1.Length; i++){
        int i1 = i;
        int f1 = s1.LastIndexOf(s1[i]);
        
        if(s2.Contains(s1[i])){
            int i2 = s2.IndexOf(s1[i]);
            int f2 = s2.LastIndexOf(s1[i]);
            
            if((f1-i1 +1) <= (f2-i2 +1)){
                count += (f1-i1 +1);
            }else {
                count += (f2-i2 +1);
            }
        }
        i=f1;
    }
    return count;
}