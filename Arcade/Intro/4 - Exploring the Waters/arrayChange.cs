int arrayChange(int[] inputArray) {
    int count = 0;
    int[] tmp = new int[inputArray.Count()];
    tmp[0] = inputArray[0];
    for(int i=1; i< inputArray.Count(); i++){
        if(inputArray[i] <= tmp[i-1]){
            int val =  (tmp[i-1]+1);
            count += val-inputArray[i];
            tmp[i] = val;
        }else{
            tmp[i] = inputArray[i];
        }
    }
    return count;
}
