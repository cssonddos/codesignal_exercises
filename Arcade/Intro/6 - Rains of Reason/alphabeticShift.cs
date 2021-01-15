string alphabeticShift(string inputString) {
    string result = "";
    for(int i=0; i< inputString.Length; i++){
        int val = inputString[i] + 1;
        char res = 'a';
        if(inputString[i] != 'z'){
            res = (char)val;
        }
        result += res;
    }
    return result;
}