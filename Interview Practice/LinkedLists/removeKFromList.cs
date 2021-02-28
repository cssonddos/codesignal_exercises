// Singly-linked lists are already defined with this interface:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> removeKFromList(ListNode<int> l, int k) {
    ListNode<int> now = l;
    ListNode<int> before = l;

    while(now != null){
        if(now.value == k){
            if(now == before){
                l = now.next;
                before = l;
                now = l;
            }else{
                before.next = now.next;
                now = now.next;
            }
        }else{
            before = now;
            now = now.next;
        }
    }
    return l;
}
