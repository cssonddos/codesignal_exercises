int[][] boxBlur(int[][] image) {
    int[][] result = new int[image.Count()-2][];
    
    int iR = 0;
    for(int i=0; i<image.Count()-2; i++){
        result[iR] = new int[image[i].Count()-2];
        
        int iC = 0;
        for(int j=0; j<image[i].Count()-2; j++){
            result[iR][iC] = checkQuad(i, j, image);
            iC++;
        }
        iR++;
    }
    return result;
}

int checkQuad(int r, int c, int[][] image){
    int sum = 0;
    for(int i = r; i<= r+2; i++){
        for(int j=c; j<=c+2; j++){
            sum += image[i][j];
        }
    }
    return sum / 9;
}