namespace Example3
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue1 = new MyQueue<int>();

            queue1.Enqueue(10);
            queue1.Enqueue(20);
            queue1.Enqueue(30);

            Console.WriteLine($"Queue1 has {queue1.Size()} elements.");

            Console.WriteLine($"Dequeued {queue1.Dequeue()} from queue1.");
            Console.WriteLine($"Dequeued {queue1.Dequeue()} from queue1.");

            Console.WriteLine($"Is queue1 empty? {queue1.IsEmpty()}");

            MyQueue<string> queue2 = new MyQueue<string>();

            queue2.Enqueue("Trong ");
            queue2.Enqueue("Hieu");
            queue2.Enqueue("Mai");

            Console.WriteLine($"Queue2 has {queue2.Size()} elements.");

            Console.WriteLine($"Dequeued {queue2.Dequeue()} from queue2.");
            Console.WriteLine($"Dequeued {queue2.Dequeue()} from queue2.");

            Console.WriteLine($"Is queue2 empty? {queue2.IsEmpty()}");

        }
    }
}