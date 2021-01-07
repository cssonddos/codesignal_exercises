string[] addBorder(string[] picture) {
    string[] res = new string[picture.Count() + 2];
    string ast = new String('*', picture[0].Length + 2);
    res[0] = ast;
    res[res.Count()-1] = ast;
    int ind = 1;
    foreach(string s in picture){
        res[ind++] = String.Format("*{0}*", s);
    }
    return res;
}