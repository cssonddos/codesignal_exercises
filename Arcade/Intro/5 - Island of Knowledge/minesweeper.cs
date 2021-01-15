int[][] minesweeper(bool[][] matrix) {
    int[][] res = new int[matrix.Count()][];
    for(int x=0; x< matrix.Count(); x++){
        res[x] = new int[matrix[x].Count()];
        
        for(int y=0; y< matrix[x].Count(); y++){
            res[x][y] = checkAround(x, y, matrix);
        }
    }
    return res;
}

int checkAround(int x, int y, bool[][] m){
    int count = 0;
    //checkLeft
    if(y-1 >=0 && m[x][y-1]){
        count++;
    }
    //checkRight
    if(y+1 < m[x].Count() && m[x][y+1]){
        count++;
    }
    //checkDown
    if(x+1 < m.Count() && m[x+1][y]){
        count++;
    }
    //checkUp
    if(x-1 >=0 && m[x-1][y]){
        count++;
    }
    count += checkUpDiag(x,y,m);
    count += checkDownDiag(x,y,m);
    return count;
}

int checkUpDiag(int x, int y, bool[][] m){
    int c=0;
    if(x-1>=0){
        if(y-1>=0){
            if(m[x-1][y-1]){ //checkleft
                c++;
            }
        }
        if(y+1< m[x].Count()){
            if(m[x-1][y+1]){ //checkright
                c++;
            }
        }
        return c;
    }else return 0;
}

int checkDownDiag(int x, int y, bool[][] m){
    int c=0;
    if(x+1 < m.Count()){
        if(y-1>=0){ //checkleft
            if(m[x+1][y-1]){
                c++;
            }
        }
        if(y+1 < m[x].Count()){ //checkright
            if(m[x+1][y+1]){
                c++;
            }
        }
        return c;
    }else return 0;
}