using System;
using SingleLinkedList;
class SinglyLinkedList
{
    public Node head;
    public Node tail;
    public int size ;

    public Node CreateSinglyLinkedList(int nodeValue)
    {
        head=new Node();
        Node node = new Node();
        node.next=null;
        node.value=nodeValue;
        head=node;
        tail=node;
        size ++;
        return head;
    }

    public void InsertNode(int nodeValue,int location)
    {
        Node node = new Node();
        node.next=null;
        node.value=nodeValue;
        if(head==null)
        {
            CreateSinglyLinkedList(nodeValue);
            return;
        }
        else if(location==0)
        {
            node.next=head.next;
            head=node;
        }
        else if(location>=size)
        {
            node.next=null;
            tail.next=node;
            tail=node;
        }
        else
        {
            Node tempNode=head;
            for(int index=0;index<location-1;index++)
            {
                tempNode=tempNode.next;
            }
            Node nextNode=tempNode.next;
            tempNode.next=node;
            node.next=nextNode;
        }
        size++;
    }

    public void TraverseSingleLinkedList()
    {
        if(head==null)
        Console.WriteLine("Linked List not exist");

        else
        {
            Node tempNode = head;
            for(int i=0;i<size;i++)
            {
                Console.Write(tempNode.value);
                if(i<size-1)
                Console.Write(" --> ");

                tempNode=tempNode.next;
            }
            Console.WriteLine();
        }
    }

    public bool SearchNode(int value)
    {
        if(head!=null)
        {
            Node tempNode=head;
            for(int i=0;i<size;i++)
            {
                if(tempNode.value==value)
                {
                Console.WriteLine("Value found at node {0}",i);
                return true;
                }
                tempNode=tempNode.next;
            }
        }
        Console.WriteLine("Node not found.");
        return false;
    }

    public void DeleteNode(int location)
    {
        if(head==null)
        Console.WriteLine("Linked List Not exist");

        else if(location==0)
        {
            head=head.next;
            size--;
            if(size==0)
                tail=null;
        }
        else if(location>=size)
        {
            Node tempNode=head;
            for(int i=0;i<size-1;i++)
            {
                tempNode=tempNode.next;
            }
            if(tempNode==head)
            {
                tail=head=null;
                size--;
                return;
            }
            tempNode.next=null;
            tail=tempNode;
            size--;
        }
        else
        {
            Node tempNode=head;
            for(int i=0;i<location-1;i++)
            {
                tempNode=tempNode.next;
            }
            tempNode.next=tempNode.next.next;
            size--;
        }
    }

    public void DeleteLinkedList()
    {
        head=null;
        tail=null;
        Console.WriteLine("Linked List deleted sucessfully.");
    }
}