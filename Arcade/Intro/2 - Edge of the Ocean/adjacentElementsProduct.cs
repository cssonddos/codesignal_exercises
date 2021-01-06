int adjacentElementsProduct(int[] inputArray) {
    int prod = 0;
    for(int i=0; i<inputArray.Length;i++){
        
        if((i+1) == inputArray.Length){
            break;
        }else{
            int res = inputArray[i] * inputArray[i+1];
            
            if(res > prod || i==0 ){
                prod = res;
            }
        }
    }
    return prod;
}