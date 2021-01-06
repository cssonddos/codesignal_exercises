string reverseInParentheses(string inputString) {
    string res = "";
    string temp = "";
    List<string> par = new List<string>();
    for(int i=0; i<inputString.Length; i++){
        if(inputString[i] != '(' && inputString[i] != ')' && par.Count==0){
            res += inputString[i];
            continue;
        }
        if(inputString[i] != '(' && inputString[i] != ')' && par.Count > 0){
            par[par.Count-1] += inputString[i];
            continue;
        }
        if(inputString[i] == '('){
            par.Add("");
        }else{
            string t = new string(par[par.Count-1].Reverse().ToArray());
            
            if(par.Count -1 > 0){
                par[par.Count-2] += t;
                par.RemoveAt(par.Count-1);
            }else{
                res += t;
                par.Clear();
            }
        }
    }
    return res;
}