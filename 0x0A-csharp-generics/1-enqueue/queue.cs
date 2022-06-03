using System;

///<summary>Generic class</summary>
public class Queue<T>
{
    public Node head = null;
    public Node tail = null;
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
        public T value = default(T);
        public Node next = null;

        public Node(T t)
        {
            value = t;
        }
    }
}
