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

    int get(int x, doubleListNode head) {
        for(int i = 0; i <= x && head.next != null; i++) head = head.next;
        return head.val;
    }

    void addNode(int x, doubleListNode head) { // add node to end of list
        while(head.next != null) head = head.next;
        head.next = new doubleListNode(head, x);
    }

    doubleListNode pop(doubleListNode head) { // remove node at end of list and return it
        int len = findLength(head);

        for(int i = 1; i < len && head.next != null; i++) head = head.next;
        if(head.next == null) return head; // Make compiler shut up
        doubleListNode toRemove = head.next;
        head.next = null;
        return toRemove;
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

    doubleListNode removeAtIndex(int x, doubleListNode head) {
        if(x > findLength(head)) throw new Exception("Index does not exist");
        for(int i = 0; i < x; i++) {
            if(head.next != null) head = head.next; // if statement to make compiler shut up
        }
        
        if(head.next != null) { // again, just to make compiler shut up
            doubleListNode toRemove = head.next;
            head.next = head.next.next;
            toRemove.next = null;
            return toRemove;
        }
        return head;
    }

    bool contains(int x, doubleListNode head) {
        if(head.val == x) return true;
        while(head.next != null) {
            if(head.val == x) return true;
            if(head.next != null)head = head.next;
        }

        return false;
    }
}