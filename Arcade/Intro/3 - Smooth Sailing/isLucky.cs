bool isLucky(int n) {
    string v = n.ToString();
    char[] l = new char[v.Length /2];
    char[] r = new char[v.Length /2];
    
    r = v.Remove(0, v.Length /2).ToCharArray();
    
    l = v.Remove(v.Length /2, v.Length /2).ToCharArray();
    int lc = 0, rc=0;
    for(int i =0; i < v.Length/2; i++){
        lc += l[i];
        rc += r[i];
    }
    return lc==rc;
}