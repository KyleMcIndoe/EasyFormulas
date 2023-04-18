public class treeNode {
    int val;
    treeNode? left;
    treeNode? right;

    public treeNode(int x) {
        val = x;
    }

    public treeNode(int x, treeNode l, treeNode r) {
        val = x;
        left = l;
        right = r;
    }
}