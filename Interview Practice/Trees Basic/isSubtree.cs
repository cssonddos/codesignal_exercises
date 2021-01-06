//
// Binary trees are already defined with this interface:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }
bool isSubtree(Tree<int> t1, Tree<int> t2) {
    if(t1 == null && t2 == null) return true;
    if(t1 == null) return false;
    if(t2 == null) return true;
    
    if(t1.value == t2.value) return  checkNode(t1,t2);
    return isSubtree(t1.left, t2) || isSubtree(t1.right, t2); 
}

bool checkNode(Tree<int> t1, Tree<int> t2){
    if(t1 == null && t2 ==null) return true;
    if((t1 == null && t2 != null) || (t1 != null && t2 == null)) return false;
    
    if(t1.value != t2.value){
        return checkNode(t1.left, t2);
    }else{
        if(checkNode(t1.left, t2.left)){
            if(checkNode(t1.right, t2.right)){
                return true;
            }
            else return false;
        }
        return false;
    }
}


