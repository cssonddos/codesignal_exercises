int matrixElementsSum(int[][] matrix) {
  int[] temp = new int[matrix[0].Count()];
    int[] chg = new int[matrix[0].Count()];
    int count = 0 ;
    for(int i =0; i< matrix.Count(); i++){
        if(i>1){
            temp = chg;
            
        }
        for(int j=0; j< matrix[i].Count(); j++){
            if(matrix[i][j] > 0){
                if(i == 0){
                    count += matrix[i][j];
                }else{
                    if(temp[j] == -1){
                        chg[j] = -1;
                    }else{
                        count += matrix[i][j];
                    }
                }
            }else{ 
                if(matrix[i][j] == 0){
                    if(i==0){
                        temp[j] = -1;
                    }else{
                        chg[j] = -1;
                    }
                }
            }
        }
    } 
    return count;
}