
namespace DataStructures;

public class DoubleLinkedList<T>
{
    public class Node(T t)
    {
        public T Value { get; set; } = t;
        public Node? Next { get; set; } = null;
        public Node? Previous { get; set; } = null;
    }

    private Node? _head;
    public Node? First => _head;
    public Node Next => _head?.Next!;
    public Node Previous => _head?.Previous!;
    public Node Last 
    {
        get
        {
            Node node = GetLastNode();
            return node;
        }
    }

    private int _count;

    public int Count
    {
        get
        {
            if (_count < 0)
            {
                _count = 0;
            }
            return _count;
        }
        private set => _count = value;
    }

    private Node GetLastNode()
    {
        if( _head is null)
        {
            return null!;
        }
        Node node = _head;
        while( node.Next != null)
        {
            node = node.Next; 
        }
        return node;
    }
    public void AddFirst(T t)
    {
        Node newNode = new(t);
        Count++;

        if(_head is not null)
        {
            _head.Next = _head;
            _head.Previous = newNode;
        } 
        _head = newNode;
    }

    public void AddLast(T t)
    {
        Node newNode = new(t);
        Count++;
        if(_head is null)
        {
            _head = newNode;
            return;
        }

        var lastNode = GetLastNode();
        
        lastNode.Next = newNode;
        newNode.Previous = lastNode;
    }

    public void AddAfter(T t, Node node)
    {
        ArgumentNullException.ThrowIfNull(node);

        var newNode = new Node(t)
        {
            Next = node.Next,
            Previous = node
        };

        Count++;
        node.Next = newNode;
        if(newNode.Next is not null)
        {
            newNode.Next.Previous = newNode;
        }

    }

    public void AddBefore(T t, Node node)
    {
        ArgumentNullException.ThrowIfNull(node);

        var newNode = new Node(t)
        {
            Previous = node.Previous,
            Next = node
        };

        Count++;
        node.Previous = newNode;
        if(newNode.Previous is not null)
        {
            newNode.Previous.Next = newNode;
            return;
        }
        _head = newNode;
    }

    public bool Contains(T t)
    {
        var node = First;

        if(node.Value.Equals(t))
        {
            return true;
        }

        while(node.Next is not null)
        {
            node = node.Next;
            if(node.Value.Equals(t))
            {
                return true;
            }
        }
        return false;
    }

    public Node Find(T t)
    {
        var node = First;

        if(node.Value.Equals(t))
        {
            return node;
        }

        while(node.Next is not null)
        {
            node = node.Next;
            if(node.Value.Equals(t))
            {
                return node;
            }
        }
        return null;
    }

    public Node FindLast(T t)
    {
        var node = Last;

        if(node.Value.Equals(t))
        {
            return node;
        }

        while(node.Previous is not null)
        {
            node = node.Previous;

            if(node.Value.Equals(t))
            {
                return node;
            }
        } 
        return null;
    }    
}