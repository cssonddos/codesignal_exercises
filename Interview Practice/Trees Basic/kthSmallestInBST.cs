//
// Binary trees are already defined with this interface:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }

public class Result{
    public int count;
    public int res;
    public Result(int x, int y){
        count = x; 
        res = y;
    }
    public string ToString(){
        return String.Format("C: {0} R:{1}",count,res);
    }
}
    
int kthSmallestInBST(Tree<int> t, int k) {
    Result result = new Result(0,0);
    helper(t, k, result);
    return result.res;
}

void helper(Tree<int> t, int k, Result result){
    if(t.left!= null) helper(t.left, k, result);
    result.count++;
    if(result.count==k){
        result.res= t.value;
        return;
    }
    if(t.right!=null) helper(t.right, k, result);
}