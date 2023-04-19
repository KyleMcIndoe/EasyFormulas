public class doubleListNode {
    int val;
    doubleListNode? prev;
    doubleListNode? next;

    public doubleListNode(int x) {
        val = x;
    }

    public doubleListNode(int x, doubleListNode n) {
        val = x;
        next = n;
    }

    public doubleListNode(doubleListNode p, int x) {
        val = x;
        prev = p;
    }

    public doubleListNode(doubleListNode p, int x, doubleListNode n) {
        val = x;
        prev = p;
        next = n;
    }

    void addNode(int x, doubleListNode head) { // add node to end of list
        while(head.next != null) head = head.next;
        head.next = new doubleListNode(head, x);
    }

    doubleListNode pop(doubleListNode head) { // remove node from end of list and return it
        return head; // TODO
    }

    doubleListNode shift(doubleListNode head) { // remove node form start of list
        if(head.next == null) return head;
        doubleListNode first = head;
        head = head.next;
        first.next = null;
        head.prev = null;
        return first;
    }

    void unshift(int x, doubleListNode head) { // add node to start of list
        doubleListNode newNode = new doubleListNode(x, head);
        head.prev = newNode;
    }

    int findLength(doubleListNode head) {
        int count = 1;
        while(head.next != null) {
            head = head.next;
            count++;
        }
        return count;
    }
}