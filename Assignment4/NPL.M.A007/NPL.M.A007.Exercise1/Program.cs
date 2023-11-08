namespace NPL.M.A007.Exercise1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", 123456789, "J.K.Rowling", "Kim Dong");
            Console.WriteLine(book.GetBookInformation());

        }
    }
}