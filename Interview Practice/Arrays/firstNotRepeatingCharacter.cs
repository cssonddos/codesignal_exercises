char firstNotRepeatingCharacter(string s) {
    int[] az = new int[256];
    List<Char> notR = new List<Char>();
    
    for(int i=0; i< s.Length; i++){
        if(!notR.Contains(s[i]) && az[(int)s[i]] == 0){
            notR.Add(s[i]);
        }else{
            notR.Remove(s[i]);
        }
        az[(int)s[i]]++;
    }
    return notR.Count >0? notR.First() : '_';
}