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

    bool isValid(BSTnode node) { // checks wether its a valid bst
        bool checkNode(BSTnode x) {
            if(x.left == null || x.right == null) return true;
            if(x.left.val > x.right.val) return false;
            if(x.left != null) checkNode(x.left);
            if(x.right != null) checkNode(x.right);
            return true;
        }

        if(checkNode(node) == false) return false;
        return true;
    }
}