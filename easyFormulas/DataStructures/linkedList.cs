public class listNode {
    int val;
    listNode? next;

    public listNode(int x) {
        val = x;
    }

    public listNode(int x, listNode y) {
        val = x;
        next = y;
    }

    int get(int x, listNode head) {
        for(int i = 0; i <= x && head.next != null; i++) head = head.next;
        return head.val;
    }

    void addNode(int x, listNode head) { // add node to the end of a list
        while(head.next != null) head = head.next;
        head.next = new listNode(x);
    }

    listNode pop(listNode head) { // remove node at end of list and return it
        int len = findLength(head);

        for(int i = 1; i < len && head.next != null; i++) head = head.next;
        if(head.next == null) return head; // Make compiler shut up
        listNode toRemove = head.next;
        head.next = null;
        return toRemove;
    }

    listNode shift(listNode head) { // remove node from start of list and return it
        if(head.next == null) return head;
        listNode node = head;
        head = head.next;
        node.next = null;
        return node;
    }

    listNode unshift(int x, listNode head) { // add noded to start of a list, and return it
        listNode newNode = new listNode(x, head);
        return newNode;
    }

    int findLength(listNode head) {
        int count = 1;
        while(head.next != null) {
            head = head.next;
            count++;
        }
        return count;
    }

    listNode removeAtIndex(int x, listNode head) {
        if(x > findLength(head)) throw new Exception("Index does not exist");
        for(int i = 0; i < x; i++) {
            if(head.next != null) head = head.next; // if statement to make compiler shut up
        }
        
        if(head.next != null) { // again, just to make compiler shut up
            listNode toRemove = head.next;
            head.next = head.next.next;
            toRemove.next = null;
            return toRemove;
        }
        return head;
    }

    bool contains(int x, listNode head) {
        if(head.val == x) return true;
        while(head.next != null) {
            if(head.val == x) return true;
            if(head.next != null)head = head.next;
        }

        return false;
    }
}