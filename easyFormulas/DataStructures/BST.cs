// BST = binary search tree

public class BSTnode {
    int val;
    BSTnode? left;
    BSTnode? right;

    public BSTnode(int x) {
        val = x;
    }

    public BSTnode(int x, BSTnode l, BSTnode r) {
        val = x;
        left = l;
        right = r;
    }

    void invert(BSTnode node) {
        BSTnode? placeholder = node.left;
        node.left = node.right;
        node.right = placeholder;

        if(node.left != null) invert(node.left);
        if(node.right != null) invert(node.right);
    }
}