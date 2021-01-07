int[] alternatingSums(int[] a) {

    bool p = true;
    int[] res = new int[2];
    foreach(int i in a){
        if(p){
            res[0] += i;
        }else{
            res[1] += i;
        }
        p = !p;
    }
    return res;
}