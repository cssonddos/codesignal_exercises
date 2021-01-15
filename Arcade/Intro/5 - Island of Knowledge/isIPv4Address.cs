bool isIPv4Address(string inputString) {
    int dots = 0;
    bool result = true;
    for(int i=0; i< inputString.Length; i++){
        if(Char.IsDigit(inputString[i])){
            continue;
        }
        if(inputString[i].Equals('.')){
            dots++;
            continue;
        }
        return false;
        break;
    }
    if(result){
        var part = inputString.Split('.');
        foreach(string p in part){
            
            int v = 0;
            bool r = int.TryParse(p, out v);
            
            if(!r || v > 255 || v < 0 || (v == 0 && p.Length>1) || (v > 0 && p.Length > 1 && p[0] == '0')){
                return false;
            }
        }
    }
    result = dots == 3? true : false;
    return result;
}
