string[] allLongestStrings(string[] inputArray) {

    int size = 0;
    List<string> result = new List<string>();
    
    foreach( string st in inputArray){
        if(st.Length > size){
            size = st.Length;
            result.Clear();
        }
        if(st.Length == size){
            result.Add(st);
        }
    }
    return result.ToArray();
}