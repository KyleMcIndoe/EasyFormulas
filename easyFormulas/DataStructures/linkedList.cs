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
        return head; // TODO
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


}