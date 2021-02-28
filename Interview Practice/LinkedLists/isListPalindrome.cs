// Singly-linked lists are already defined with this interface:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
bool isListPalindrome(ListNode<int> l) {
    if (l == null) return true;
    if (l.next == null) return true;
    
    List<int> c = new List<int>();
    ListNode<int> i = l;
    
    while(i != null){
        c.Add(i.value);
        i = i.next;
    }
    i=l;
    int count=c.Count-1;
    for(int it = 0; it <c.Count; it++, count --){
        if(c[it] != c[count]){
            return false;
        }
    }
    return true;
}
