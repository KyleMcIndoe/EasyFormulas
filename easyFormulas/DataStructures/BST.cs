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

    void add(int x, BSTnode node) {
        while(true) {
            if(x > node.val && node.right == null) {
                node.right = new BSTnode(x);
                return;
            }
            if(x < node.val && node.left == null) {
                node.left = new BSTnode(x);
                return;
            }

            if(x > node.val && node.right != null) node = node.right;
            if(x < node.val && node.left != null) node = node.left;
        }
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

    int numNodes(BSTnode root) {
        int count = 0;
        void countNodes(BSTnode node) {
            count++;
            if(node.left != null) countNodes(node.left);
            if(node.right != null) countNodes(node.right);
        }
        countNodes(root);
        return count;
    } 

    bool contains(int x, BSTnode root) {
        bool search(BSTnode node) {
            if(node.val == x) return true;
            if(node.left != null) search(node.left);
            if(node.right != null) search(node.right);
            return false;
        }

        return search(root);
    }
}