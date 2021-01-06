bool almostIncreasingSequence(int[] sequence) {
    int invalidItemsCount = 0;
  
    for (int i = 1; i < sequence.Length; i++) {
        if (sequence[i] <= sequence[i-1]) {
            invalidItemsCount++;
            if (invalidItemsCount > 1){
              return false;  
            } 
            if (i-2>=0 && i+1<sequence.Length && sequence[i] <= sequence[i-2] && sequence[i+1] <= sequence[i-1]){
                 return false;
            }
        }
    }
  
  return true;
}