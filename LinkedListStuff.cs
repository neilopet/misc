using System;

public class Program
{
	public static void Main()
	{
		Node root = new Node();
		root.data = 1;
		root.next = null;
		
		Node child1 = new Node();
		child1.data = 2;
		child1.next = null;
		
		root.next = child1;
		
		Node child2 = new Node();
		child2.data = 3;
		child2.next = null;
		
		child1.next = child2;
		
		root = reverseLL( root );
		
		printLL( root );
	}
	
	public static void printLL( Node n )
	{
		Console.WriteLine( n.data );
		if (n.next != null)
			printLL( n.next );		
	}
	
	public static Node reverseLL( Node n )
	{
		if (n == null || n.next == null)
		{
			return n;
		}
		
		Node ret = reverseLL( n.next );
		
		Node nextNode = n.next;
		n.next = null;
		nextNode.next = n;
		
		return ret;
	}			
}

public class Node 
{
	public int data;
	public Node next;
}
