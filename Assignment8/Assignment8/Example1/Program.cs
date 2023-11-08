namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyStack<int> stack1 = new MyStack<int>();

            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);
            Console.WriteLine($"Stack1 has {stack1.Size()}  elements.");

            Console.WriteLine($"Popped {stack1.Pop()} from stack1.");
            Console.WriteLine($"Popped {stack1.Pop()} from stack1.");


            Console.WriteLine($"Peeked {stack1.Peek()} from stack1.");

            Console.WriteLine($"Is stack1 empty? {stack1.IsEmpty()}");
            Console.WriteLine();

            MyStack<string> stack2 = new MyStack<string>();

            stack2.Push("Mai");
            stack2.Push("Trong");
            stack2.Push("Hieu");

            Console.WriteLine($"Stack2 has {stack2.Size()} elements.");

            Console.WriteLine($"Popped {stack2.Pop()} from stack2.");
            Console.WriteLine($"Popped {stack2.Pop()} from stack2.");

            Console.WriteLine($"Peeked {stack2.Peek()} from stack2.");
            Console.WriteLine($"Is stack2 empty? {stack2.IsEmpty()}");




        }
    }
}