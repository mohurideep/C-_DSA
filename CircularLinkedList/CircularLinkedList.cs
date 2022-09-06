using System;
using CircularLinkedList;

class  SinglyCircularLinkedList
{
    public Node head;
    public Node tail;
    public int size;

    public Node CreateCircularLinkedList(int nodeValue)
    {
        head = new Node();
        Node node = new Node();
        node.value=nodeValue;
        node.next=node;
        head=node;
        tail=node;
        size++;
        return head;
    }

    public void Insert(int nodeValue,int position)
    {
        Node node = new Node();
        node.value=nodeValue;
        if(head==null)
        {
            CreateCircularLinkedList(nodeValue);
            return;
        }
        else if(position==0)
        {
            node.next=head;
            tail.next=node;
            head=node;
            //tail.next=head;

        }
        else if(position>=size)
        {
            node.next=head;
            tail.next=node;
            tail=node;
            //tail.next=head;
        }
        else
        {
            Node tempNode=head;
            for(int i=0;i<position-1;i++)
            {
                tempNode=tempNode.next;
            }
            Node nextNode=tempNode.next;
            tempNode.next=node;
            node.next=nextNode;
        }
        size++;
    }

    public void TraverseCircularLinkedList()
    {
        if(head==null)
        {
            Console.WriteLine("LinkedList not exist");
            return;
        }
        Node tempNode=head;
        for(int i=0;i<size;i++)
        {
            Console.Write(tempNode.value);
            if(i<size-1)
            {
                Console.Write("-->");
            }
            tempNode=tempNode.next;
        }
        Console.WriteLine();
    }

    public bool SearchNode(int nodeValue)
    {
        if(head==null)
        {
            Console.WriteLine("LinkedList Not exist.");
            return false;
        }
        Node tempNode=head;
        for(int i=0;i<size;i++)
        {
            if(tempNode.value==nodeValue)
            {
                Console.WriteLine("Value found at Node {0}",i);
                return true;
            }
            tempNode=tempNode.next;
        }
        Console.WriteLine("Value not found");
        return false;
    }

    public void DeleteNode(int location)
    {
        if(head!=null)
        {
            if(location==0 || location>=size && size==1)
            {
                head=null;
                tail=null;
                size--;
            }
            else if(location==0)
            {
                head=head.next;
                tail.next=head;
                size--;
            }
            else if(location>=size)
            {
                Node tempNode=head;
                for(int i=1;i<size-1;i++)
                {
                    tempNode=tempNode.next;
                }
                tempNode.next=head;
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
    }

    public void DeleteCircularLinkedList()
    {
        head=null;
        tail.next=null;
        tail=null;
    }
}