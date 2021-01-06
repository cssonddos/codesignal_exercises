int[][] rotateImage(int[][] a) {
    int s = a.Length;
    int[][] b = new int[s][];
    
    for(int x=0; x < s; x++)
    {
        int ind = 0;
        for(int y=s-1; y >=0; y--)
        {
            if(b[x] == null){
                b[x] =new int[s];
            }
            b[x][ind++] = a[y][x];
        }
    }

    return b;
}