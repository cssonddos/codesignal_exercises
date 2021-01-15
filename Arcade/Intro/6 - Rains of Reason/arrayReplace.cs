int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem) {
    for(int i=0; i< inputArray.Count(); i++){
        if(inputArray[i] == elemToReplace){
            inputArray[i] = substitutionElem;
        }
    }
    return inputArray;
}