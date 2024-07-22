public class Node
{
    public int Value;
    public Node Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class Program
{
    public static void Main()
    {
        Node main = new Node(1);
        main.Next = new Node(2);

        // Assign the 'main' node to 'current'
        Node current = main;

        // Traverse the linked list
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
