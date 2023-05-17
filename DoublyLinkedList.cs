
using System.Reflection.Metadata.Ecma335;

public class DoublyLinkedList
    {
        Node head;
        Node tail; 
        int count;
    public int HeadData { get { return head.Data; } }
    public int TailData { get { return tail.Data; } }
    public Node Head { get { return head; } }
    
    public Node Tail { get { return tail; } }

        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            Node tmp = head;
            node.Next = tmp;
            head = node;
            if (count == 0)
                tail = head;
            else
                tmp.Previous = node;
            count++;
        }
        
        public bool Remove(int data)
        {
            Node current = head;

            
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
               
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    
                    tail = current.Previous;
                }

              
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
    public string StrList()
    {
        Node current = head;
        string str = " ";
        if (current == null)
            return "empty";
        str += current.Data;
        current = current.Next;
        while (current != null)
        {
            str = str + " " + current.Data;
            current = current.Next;
        }
        return str;
    }
    public override string ToString()
    {
        Node current = head;
        string str = " ";
        if (current == null)
            return "пусто";
        str += current.Data;
        current = current.Next;
        while (current != null) 
        {
            str = str + " " + current.Data;
            current = current.Next;
        }
        return str;
    
    }
    

}









