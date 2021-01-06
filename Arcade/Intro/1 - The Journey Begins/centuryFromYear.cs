int centuryFromYear(int year) {
    
    if(year/100 > 0){
        if( ((year/100)*100 - year)==0){
            return year/100;
        } else{
            return year/100 + 1;
        }
    }
    return 1;
}