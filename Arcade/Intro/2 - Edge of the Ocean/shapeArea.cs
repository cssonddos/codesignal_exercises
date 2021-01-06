int shapeArea(int n) {
    if(n==1)
        return 1;
    else{
        int prog = next2(2, 4, n);
        return (n*2) -1 + prog;
        
    }
}

int next2(int value, int n, int level){
    if(level ==2)return value;
    int stage = value + n;
    return next2(stage, n, level -1) + value;
}