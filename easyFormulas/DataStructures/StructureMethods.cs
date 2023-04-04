public static class linkedListMethods {
    public static void removeNext(listNode node) {
        if(node.next == null) return;
        node.next = node.next.next;
    }
}