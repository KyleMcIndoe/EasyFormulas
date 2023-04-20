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

    void addNode(int x, listNode head) { // add node to the end of a list
        while(head.next != null) head = head.next;
        head.next = new listNode(x);
    }

    listNode pop(listNode head) { // remove node at end of list and return it
        return head;// cant make anything without the compiler screaming at me
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
}