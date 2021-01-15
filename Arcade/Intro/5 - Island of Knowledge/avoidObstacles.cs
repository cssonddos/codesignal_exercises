int avoidObstacles(int[] inputArray) {
    
    for(int i=2; i<=inputArray.Max(); i++){
        bool t = true;
        for(int j=0; j< inputArray.Count(); j++){
            if(inputArray[j] % i == 0){
                t = false;
                break;
            }
        }
        if(t){
            return i;
        }
    }
    return inputArray.ToList().Max() + 1;

}
