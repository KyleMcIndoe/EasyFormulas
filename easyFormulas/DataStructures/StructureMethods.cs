public static class linkedListMethods {
    public static void removeNext(listNode node) {
        if(node.next == null) return;
        node.next = node.next.next;
    }

    public static void push(int x, listNode head) { // add node at end of list
        listNode placeHolder = head;
        while(head.next != null) head = head.next;
        head.next = new listNode(x);
        head = placeHolder;
    }

    public static void unshift(int x, listNode head) { // add node at start of list
        listNode cur = new listNode(x);
        cur.next = head;
        head = cur;
    }

    public static listNode pop(listNode head) { // takes away node at end of list and returns it
        while(head.next != null) head = head.next;
        if(head.next == null) return head; // not needed, only there to make vscode shut up
        listNode last = head.next;
        head.next = null;
        return last;
    }
}