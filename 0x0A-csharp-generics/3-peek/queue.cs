using System;

///<summary>Generic class</summary>
public class Queue<T>
{
    ///<summary>head of the queue</summary>
    public Node head = null;
    ///<summary>tail of the queue</summary>
    public Node tail = null;
    ///<summary>count of the queue</summary>
    public int count = 0;

    ///<summary>Creates a new node</summary>
    public void Enqueue(T val)
    {
        Node neu = new Node(val);
        if (head == null && tail == null)
        {
            head = neu;
            tail = neu;
        }
        else
        {
            tail.next = neu;
            tail = neu;
        }
        count += 1;
    }
    
     ///<summary>Removes from a queue.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        Node old = head;
        head = old.next;
        count -= 1;
        return (old.value);
    }

    ///<summary>Peeks at a queue.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (head.value);
    }

    ///<summary>Counts the queue</summary>
    public int Count()
    {
        return (count);
    }

    ///<summary>returns the Queue’s type</summary>
    public string CheckType()
    {
        return(typeof(T).ToString());
    }

    ///<summary>Node constructor</summary>
    public class Node
    {
        ///<summary>value of a node</summary>
        public T value = default(T);
        ///<summary>next node</summary>
        public Node next = null;

        ///<summary>node constructor</summary>
        public Node(T t)
        {
            value = t;
        }
    }
}
