bool chessBoardCellColor(string cell1, string cell2) {
    if(cell1.Equals(cell2)) return true;
    
    int c1 = checkCell(cell1);
    int c2 = checkCell(cell2);
    return c1 == c2;
}

int checkCell(string c){
    int l = c[0] - (int)'A';
    int v = (int)Char.GetNumericValue(c[1]) - 1;
    return (l+v) % 2;
}