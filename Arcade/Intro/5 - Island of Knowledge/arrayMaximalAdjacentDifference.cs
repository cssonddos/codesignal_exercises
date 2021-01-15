int arrayMaximalAdjacentDifference(int[] inputArray) {
    int max = 0;
    
    for(int i=0; i< inputArray.Count()-1; i++){
        int ltr = inputArray[i] - inputArray[i+1];
        int rtl = inputArray[i+1] - inputArray[i];
        ltr = ltr > rtl ? ltr : rtl;
        
        if(i==0){
            max = ltr;
        }else{
            max = ltr > max ? ltr : max;
        }
    }
    return max;
}
