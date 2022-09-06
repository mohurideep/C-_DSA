public class DoublyLinkedList
{
    public DoubleNode head;
    public DoubleNode tail;
    int size;

    public DoubleNode CreateDll(int nodeValue)
    {
        DoubleNode newNode = new DoubleNode();
        newNode.value = nodeValue;
        newNode.next=null;
        newNode.prev=null;
        head=newNode;
        tail=newNode;
        size=1;

        return head;
    }
}