int firstDuplicate(int[] a) {
    if(a.Length ==1){
         return -1;
    }else if(a.Length==2){
        return a[0]==a[1]? a[0] : -1;
    }else if(a.Length ==3){
        if(a[0]==a[2]){
            return a[0];
        }
        return a[1]==a[2]? a[1] : -1;
    }
    return check(a);
}

int check(int[] a){
    int [] cntarray = new int[a.Length+1];
    int min = -1;
    for (int i=0;i < a.Length ;i++) {
        if (cntarray[a[i]] == 0) {
            cntarray[a[i]]++;
        } else {
            min = a[i];
            break;
        }
    }
    return min;
}