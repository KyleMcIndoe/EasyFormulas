public static class linkedListMethods {
    public static void removeNext(listNode node) {
        if(node.next == null) return;
        node.next = node.next.next;
    }

    public static void push(int x, listNode head) { // add node at end of list
        listNode placeHolder = head;
        while(head.next != null) head = head.next;
        head.next = new listNode(x);
        head = placeHolder;
    }

    public static void unshift(int x, listNode head) { // add node at start of list
        listNode cur = new listNode(x);
        cur.next = head;
        head = cur;
    }

    public static listNode pop(listNode head) { // takes away node at end of list and returns it
        while(head.next != null) head = head.next;
        if(head.next == null) return head; // not needed, only there to make vscode shut up
        listNode last = head.next;
        head.next = null;
        return last;
    }

    public static listNode shift(listNode head) { // takes away the node at the start of the list and returns it
        listNode x = head;
        if(head.next == null) return head;
        head = head.next;
        x.next = null;
        return x;
    }
}

public static class treeMethods {
    public static void invert(treeNode node) {
        if(node.left == null && node.right == null) return;  
        treeNode? place = node.left;
        node.left = node.right;
        node.right = place;

        if(node.left != null) invert(node.left);
        if(node.right != null) invert(node.right);
    }


    public static listNode flatten(treeNode node) { // flatten tree to linked list
        listNode listHead = new listNode(node.val);

        void addToList(treeNode x, listNode list) {
            int val = x.val;
            linkedListMethods.push(val, list);

            if(x.left != null) addToList(x.left, list);
            if(x.right != null) addToList(x.right, list);
        }

        if(node.left != null)addToList(node.left, listHead);
        if(node.right != null)addToList(node.right, listHead);

        return listHead;
    }
}

public static class bstMethods { // binary search tree
    public static void add(int x) {

    }
}