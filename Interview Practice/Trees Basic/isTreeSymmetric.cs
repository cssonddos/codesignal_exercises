//
// Binary trees are already defined with this interface:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }
bool isTreeSymmetric(Tree<int> t) {
        if(t==null) return true;
	    return helper(t.left, t.right);
}


bool helper(Tree<int> t, Tree<int> t1){
    if(t==null && t1==null) return true;
    if(t==null || t1==null) return false;
    if(t.value != t1.value) return false;
    return helper(t.left, t1.right) && helper(t.right, t1.left);
} 