public class listNode { // linked list
    int? val;
    listNode? next;

    public listNode(int x, listNode y) {
        val = x;
        next = y;
    }
}

public class treeNode { // binary tree
    int? val;
    treeNode? left;
    treeNode? right;

    public treeNode(int x, treeNode y, treeNode z) {
        val = x;
        left = y;
        right = z;
    }
}

public class doubleListNode { // doubly linked list
    int? val;
    doubleListNode? prev;
    doubleListNode? next;

    public doubleListNode(int x, doubleListNode y, doubleListNode z) {
        val = x;
        prev = y;
        next = z;
    }
}