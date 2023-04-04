public class listNode { // linked list
    public int? val;
    public listNode? next;

    public listNode(int x, listNode y) {
        val = x;
        next = y;
    }
}

public class treeNode { // binary tree
    public int? val;
    public treeNode? left;
    public treeNode? right;

    public treeNode(int x, treeNode y, treeNode z) {
        val = x;
        left = y;
        right = z;
    }
}

public class doubleListNode { // doubly linked list
    public int? val;
    public doubleListNode? prev;
    public doubleListNode? next;

    public doubleListNode(int x, doubleListNode y, doubleListNode z) {
        val = x;
        prev = y;
        next = z;
    }
}