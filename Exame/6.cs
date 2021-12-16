
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2
{

	using System;
	using System.Collections;


	public class MyStack
	{
		public Stack s;
		public int minEle;
		public MyStack()
		{
			s = new Stack();
		}
		public void getMin()
		{
			if (s.Count == 0)
				Console.WriteLine("Stack is empty");

			else
				Console.WriteLine("Minimum Element in the " +
								" stack is: " + minEle);
		}

		public void Peek()
		{
			if (s.Count == 0)
			{
				Console.WriteLine("Stack is empty ");
				return;
			}

			int t = (int)s.Peek();

			Console.Write("Top Most Element is: ");

			if (t < minEle)
				Console.WriteLine(minEle);
			else
				Console.WriteLine(t);
		}

		public void Pop()
		{
			if (s.Count == 0)
			{
				Console.WriteLine("Stack is empty");
				return;
			}

			Console.Write("Top Most Element Removed: ");
			int t = (int)s.Pop();

			if (t < minEle)
			{
				Console.WriteLine(minEle);
				minEle = 2 * minEle - t;
			}

			else
				Console.WriteLine(t);
		}
		public void Push(int x)
		{
			if (s.Count == 0)
			{
				minEle = x;
				s.Push(x);
				Console.WriteLine("Number Inserted: " + x);
				return;
			}
			if (x < minEle)
			{
				s.Push(2 * x - minEle);
				minEle = x;
			}

			else
				s.Push(x);

			Console.WriteLine("Number Inserted: " + x);
		}
	}
	public class main
	{
		public static void Main(String[] args)
		{
			MyStack s = new MyStack();
			s.Push(3);
			s.Push(5);
			s.getMin();
			s.Push(2);
			s.Push(1);
			s.getMin();
			s.Pop();
			s.getMin();
			s.Pop();
			s.Peek();
		}
	}


}

