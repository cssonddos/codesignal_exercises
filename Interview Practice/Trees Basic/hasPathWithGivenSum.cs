//
// Binary trees are already defined with this interface:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }
bool hasPathWithGivenSum(Tree<int> t, int s) {
    if(t == null) return false;
    if(t.left == null && t.right == null){
        return t.value == s ? true : false;
    }
    
    if(t.left != null){
        if( cL(t.left, s, t.value)){
            return true;
        }
    }
    
    if(t.right != null){
        if(cL(t.right, s, t.value)){
            return true;
        }
    }
        

    return false;
}

bool cL(Tree<int> t, int s, int sum){
    
    if(t.left != null){
        if( cL(t.left, s, sum+t.value) ){
            return true;
        }else{
            if(t.right != null){
                if( cL(t.right, s, sum+t.value) ){
                    return true;
                }
                return false;
            }
            return false;
        }
    }else{
        if(t.right != null){
            if( cL(t.right, s, sum+t.value) ){
                return true;
            }
            return false;
        }else{
            if((sum + t.value ) == s){
                return true;
            }
            return false;
        }
    }
}