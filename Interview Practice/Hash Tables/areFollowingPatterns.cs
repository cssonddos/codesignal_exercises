bool areFollowingPatterns(string[] strings, string[] patterns) {
    if(strings.Count() == 1 && patterns.Count() == 1)
        return true;
    if(strings.Count() != patterns.Count())
        return false;    
    
    Dictionary<string, string> dict = new Dictionary<string, string>();
    
    for(int i=0; i< strings.Count(); i++){
        if(!dict.ContainsKey(strings[i]) ){
            if(dict.ContainsValue(patterns[i])){
                return false;
            }
            dict.Add(strings[i], patterns[i]);
        }else{
            if(dict[strings[i]] != patterns[i]){
                return false;
            }
        }
    }
    
    return true;
}