bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
    int yourStr = yourLeft >= yourRight? yourLeft : yourRight;
    int friendStr = friendsLeft >= friendsRight? friendsLeft : friendsRight;
    int yourW = yourLeft <= yourRight? yourLeft : yourRight;
    int friendW = friendsLeft <= friendsRight? friendsLeft : friendsRight;
    
    return armsStrong(yourStr, friendStr, yourW, friendW);
}

bool armsStrong(int yS, int fS, int yW, int fW){
    return  yS == fS && yW == fW ? true : false;
}