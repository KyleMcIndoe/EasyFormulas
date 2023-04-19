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

    void invert(treeNode node) {
        treeNode? placeholder = node.left;
        node.left = node.right;
        node.right = placeholder;

        if(node.left != null) invert(node.left);
        if(node.right != null) invert(node.right);
    }
}