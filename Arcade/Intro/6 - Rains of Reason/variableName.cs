bool variableName(string name) {
    if(char.IsDigit(name[0])) return false;
    
    for(int i=0; i<name.Length; i++){
        if(!Char.IsLetterOrDigit(name[i]) && name[i] != '_') return false;    
        
    }
    return true;
}
