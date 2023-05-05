public class multiLevelListNode {
    int val;
    multiLevelListNode? next;
    multiLevelListNode? child;

    public multiLevelListNode(int v) {
        val = v;
        next = null;
        child = null;
    }

    public multiLevelListNode(int v, multiLevelListNode n) {
        val = v;
        next = n;
        child = null;
    }

    public multiLevelListNode(multiLevelListNode c, int v) {
        val = v;
        next = null;
        child = c;
    }

    public multiLevelListNode(int v, multiLevelListNode n, multiLevelListNode c) {
        val = v;
        next = n;
        child = c;
    }

    bool containts(int x, multiLevelListNode head) {
        while(head != null) {
            if(head.child != null && containts(head.child) == true) return true;
            if(head.val == x) return true;
            head = head.next;
        }

        return false;
    }

    void add(int x, multiLevelListNode head, int level) { // Adds a node as far down as the level will allow it
        int curLevel = 1;
        while(head.next != null) {
        if(head.next == null ) head.next = new multiLevelListNode(x);
            if(head.child != null && curLevel < level) {
                head = head.child;
            } else {
                head = head.next;
            }
        }
    }

    listNode flatten(multiLevelListNode head) {
        listNode newHead = new listNode(head.val);
        listNode temp = newHead;
        void addToList(multiLevelListNode node) {
            while(node != null) {
                newHead.next = new listNode(node.val);
                newHead = newHead.next;
            }
            if(node.child != null) addToList(node.child);
            node = node.next;
        }
        return temp;
    }
}