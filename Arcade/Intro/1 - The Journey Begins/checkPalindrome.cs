bool checkPalindrome(string inputString) {
    char[] array = new char[inputString.Length];
    int ind = 0;
    for(int it = inputString.Length-1; it >=0; it--){
        array[ind++] = inputString[it];
    }
    return inputString.Equals(new string(array), StringComparison.Ordinal);
}