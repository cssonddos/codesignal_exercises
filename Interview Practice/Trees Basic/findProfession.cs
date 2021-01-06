string findProfession(int level, int pos) {
    if(level==1)
        return "Engineer";
        
    String res = findProfession(level-1,(pos+1)/2);
    if( res == "Doctor"){
        if(pos%2!=0) return "Doctor";
        else return "Engineer";
    }
    if(pos%2!=0) return "Engineer";
    else return "Doctor";   
}