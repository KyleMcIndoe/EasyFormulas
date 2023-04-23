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

    int numNodes(treeNode root) {
        int count = 0;
        void countNodes(treeNode node) {
            count++;
            if(node.left != null) countNodes(node.left);
            if(node.right != null) countNodes(node.right);
        }
        countNodes(root);
        return count;
    } 

    bool contains(int x, treeNode root) {
        bool search(treeNode node) {
            if(node.val == x) return true;
            if(node.left != null) search(node.left);
            if(node.right != null) search(node.right);
            return false;
        }

        return search(root);
    }
}