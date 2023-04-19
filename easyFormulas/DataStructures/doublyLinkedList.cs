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

    public doubleListNode(doubleListNode p, int x, doubleListNode n) {
        val = x;
        prev = p;
        next = n;
    }
}