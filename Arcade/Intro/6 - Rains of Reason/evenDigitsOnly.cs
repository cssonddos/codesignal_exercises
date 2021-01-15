bool evenDigitsOnly(int n) {
    foreach(char c in n.ToString()){
        if(int.Parse(c.ToString()) % 2 != 0){
            return false;
        }
    }
    return true;
}
