bool sudoku2(char[][] grid) {
    int quad = 0, quad1 = 0;
    for(int x = 0; x< grid.Count(); x++){
        
        if(checkDupLine(grid[x] ) != -1){
            return false;
        }
        if(checkDupColumn(grid, x) != -1){
            return false;
        }
        if(checkDupQuad(grid, quad1, quad) != -1){    
            return false;
        }
        quad1 = quad == 6 ? quad1+3 : quad1;
        quad = quad != 6 ? quad+3 : 0;
        
    }
    return true;
}

int checkDupQuad(char[][] a, int q0, int q1){
    int [] cntarray = new int[10];
    int min = -1;
    
    for(int x = q0; x < q0+3; x++){
        for(int y = q1; y < q1+3; y++){
            if(a[x][y] != '.'){
                
                if (cntarray[ (int)Char.GetNumericValue(a[x][y])] == 0) {
                    cntarray[(int)Char.GetNumericValue(a[x][y]) ]++;
                } else {
                    min = (int)Char.GetNumericValue(a[x][y]);
                    break;
                }
            }
        }
    }
    return min;
}

int checkDupLine(char[] a){
    int [] cntarray = new int[a.Length+1];
    int min = -1;
    for (int i=0;i < a.Length ;i++) {
        if(a[i] != '.'){
            if (cntarray[ (int)Char.GetNumericValue(a[i])] == 0) {
                cntarray[(int)Char.GetNumericValue(a[i]) ]++;
            } else {
                min = (int)Char.GetNumericValue(a[i]);
                break;
            }
        }
    }
    return min;
}

int checkDupColumn(char[][] a, int x){
    int [] cntarray = new int[a.Length+1];
    int min = -1;
    for (int i=0;i < a.Length ;i++) {
        if(a[i][x] != '.'){
            if (cntarray[ (int)Char.GetNumericValue(a[i][x])] == 0) {
                cntarray[(int)Char.GetNumericValue(a[i][x]) ]++;
            } else {
                min = (int)Char.GetNumericValue(a[i][x]);
                break;
            }
        }
    }
    return min;
}